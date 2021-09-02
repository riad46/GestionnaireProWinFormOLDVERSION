using System;
using System.Management;

namespace Gestionnaire_Pro.Assets
{
    public static class ProgramActivation
    {
        private  static string GetHardDiskSerialNumber()
        {
            ManagementObjectSearcher myDisks = new ManagementObjectSearcher(@" 
             SELECT SerialNumber FROM Win32_DiskDrive WHERE 
             SerialNumber IS NOT NULL AND
             MediaType ='Fixed hard disk media'");
            foreach (var disk in myDisks.Get())
            {
               return (disk["SerialNumber"].ToString());
            }
            return "";

        }
        private static string Shuffle(string str)
        {

            string res = "";
            var positionsArray = new int[str.Length];
            int initNum = 123789;
            positionsArray[0] = initNum %str.Length;
            for(int i=1;i<str.Length;i++)
            {
                initNum -= 1033;
                positionsArray[i] = initNum %str.Length;
                
            }
            
            for (int i = 0; i < str.Length; i++)
            {
                res+= str[positionsArray[i]].ToString();
            }
            return res;
        }

        public static string GetThisActivationCode()
        {
            var serialNumber = GetHardDiskSerialNumber().Trim();
            serialNumber += "RWAMSDF200019751969";
            serialNumber=serialNumber.Remove(serialNumber.Length - 20, 4);
            serialNumber = Shuffle(serialNumber);
            
            return serialNumber;
        }
    }
}
