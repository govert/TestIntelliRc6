using ExcelDna.Integration;
using ExcelDna.IntelliSense;

namespace TestIntelliRc6
{
    public class AddIn : IExcelAddIn
    {
        public void AutoOpen()
        {
            IntelliSenseServer.Install();
        }

        public void AutoClose()
        {
            IntelliSenseServer.Uninstall();
        }
    }
}