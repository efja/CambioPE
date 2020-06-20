using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambioPE
{
    public class rede
    {
        // 
        // Busca as tarxetas de rede do equipo.
        // A idea o principio era cambiar a porta de enlace só da tarxeta de rede selecionada
        // De momento non se emprega para nada        
        public static System.Object[] F_buscar_tarxetas_rede()
        {
            NetworkInterface[] TarxetasRede = NetworkInterface.GetAllNetworkInterfaces();
            IPInterfaceProperties TarxetasRedePropiedades = null;
            System.Object[] listaTarxetas = new System.Object[100];
            int i = 0;

            foreach (NetworkInterface AdaptadorRede in TarxetasRede)
            {
                TarxetasRedePropiedades = AdaptadorRede.GetIPProperties();
                IPInterfaceProperties PropiedadesAdaptadores = AdaptadorRede.GetIPProperties();
                GatewayIPAddressInformationCollection direccions = PropiedadesAdaptadores.GatewayAddresses;
                if ((direccions.Count > 0) && (AdaptadorRede.Description.IndexOf("Microsoft") != 0))
                {
                    foreach (GatewayIPAddressInformation direccion in direccions)
                    {
                        listaTarxetas[i] = AdaptadorRede.Description.ToString();
                        i++;
                    }
                }
            }

            // Adaptase a matriz de saída para evitar que leve valores nulos
            Array.Resize(ref listaTarxetas, i);
            return listaTarxetas;
        }

        // 
        // Comproba cal é a porta de enlace da primeira tarxeta de rede
        public static IPAddress F_pe_actual()
        {
            return NetworkInterface
                .GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up)
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
                .Select(g => g?.Address)
                .FirstOrDefault(a => a != null);
        }
        
        // 
        // Cambia a porta de enlace de calquer conexión activa
        public static void cambiarPE (string ip)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    try
                    {
                        ManagementBaseObject setGateway;
                        ManagementBaseObject newGateway =
                            objMO.GetMethodParameters("SetGateways");

                        newGateway["DefaultIPGateway"] = new string[] { ip };
                        newGateway["GatewayCostMetric"] = new int[] { 1 };

                        setGateway = objMO.InvokeMethod("SetGateways", newGateway, null);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
    }
}