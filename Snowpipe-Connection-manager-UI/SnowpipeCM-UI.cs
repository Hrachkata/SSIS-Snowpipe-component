using Microsoft.SqlServer.Dts.Runtime;
using Microsoft.SqlServer.Dts.Runtime.Design;
using System;

namespace Snowpipe_Connection_manager_UI
{
    public class SnowpipeCM_UI : IDtsConnectionManagerUI
    {
        public void Delete(System.Windows.Forms.IWin32Window parentWindow)
        {
            throw new NotImplementedException();
        }

        public bool Edit(System.Windows.Forms.IWin32Window parentWindow, Connections connections, ConnectionManagerUIArgs connectionUIArg)
        {
            throw new NotImplementedException();
        }

        public void Initialize(ConnectionManager connectionManager, IServiceProvider serviceProvider)
        {
            var test = new AboutBox1();
            test.Show();
        }

        public bool New(System.Windows.Forms.IWin32Window parentWindow, Connections connections, ConnectionManagerUIArgs connectionUIArg)
        {
            throw new NotImplementedException();
        }
    }
}
