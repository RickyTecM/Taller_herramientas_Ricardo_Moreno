using System;
using System.Text;

namespace AZUpload
{ 
    public class AzFiles 
     {
        private static int xMenuChoiceA;

        static void Main(string[] args)
        {
                   
                Console.WriteLine("Upload PSTs to Microsoft Azure Blob Storage using SAS Token");
                StringBuilder sb = new StringBuilder();
                sb.Append("log something");
                // flush every 20 seconds as you do it
                // File.AppendAllText(filePath + "log.txt", sb.ToString());
                sb.Clear();
            int xMenuChoiceA = 0;
            do
            {
                
                while ((xMenuChoiceA > -1) & (xMenuChoiceA < 3))
                {

                    Console.WriteLine("Please Select an option from the following choice.");
                    Console.WriteLine("");
                    Console.WriteLine("1. Upload Specific PST file (mention path under script)");
                    Console.WriteLine("2. Upload ALL PST files within the specific folder (mention path under script)");
                    Console.WriteLine("3. Quit and exit");
                    Console.WriteLine("");
                    Console.WriteLine("Please enter an option 1 to 3...");
                    xMenuChoiceA = int.Parse(Console.ReadLine());

                    switch (xMenuChoiceA) {
                    '1'(
                    F:\AzCopy_Script\azcopy copy "F:\CrashPlan_Report\PSTs_RestoredFromCP\user" "https://724c89b02b4e4093b6571e3.blob.core.windows.net/ingestiondata?sv=2015-04-05&sr=c&si=IngestionSasForAzCopy202301051759063090&sig=SBC%2Fy%2BbdrnQPSsOtWjQsorbrlabNbPb61oKYlsyGlc8%3D&se=2023-09-09T17%3A55%3A50Z"--check - length = false
                        );
                    '2'(
                    F:\AzCopy_Script\azcopy copy "F:\CrashPlan_Report\PSTs_RestoredFromCP\user\*pst" "https://724c89b02b4e4093b6571e3.blob.core.windows.net/ingestiondata?sv=2015-04-05&sr=c&si=IngestionSasForAzCopy202301051759063090&sig=SBC%2Fy%2BbdrnQPSsOtWjQsorbrlabNbPb61oKYlsyGlc8%3D&se=2023-09-09T17%3A55%3A50Z"--check - length = false
                        );
                    '3'{
                        break;
                        } 

                    default { Write - Host "Please make a selection." }

                }
                }
            } while (xMenuChoiceA != 3);

        }
    }

}