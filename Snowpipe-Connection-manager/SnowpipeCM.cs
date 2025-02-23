using Microsoft.SqlServer.Dts.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowpipe_Connection_manager
{
    [DtsConnection(
    DisplayName = "SNOWPIPE",
    ConnectionType = "SNOWPIPE",
    Description = "Connection Manager for Snowpipe",
    UITypeName = "Snowpipe_Connection_manager_UI.SnowpipeCM_UI," +
        "Snowpipe-Connection-manager-UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=24206b76cd1fde6c, processorArchitecture=MSIL")]
    public class SnowpipeCM : ConnectionManagerBase
    {
        public override object AcquireConnection(object txn)
        {
            return base.AcquireConnection(txn);
        }

        public override void ReleaseConnection(object txn) { base.ReleaseConnection(txn); }

        public override void Update(ref string ObjectXml)
        {
            base.Update(ref ObjectXml);
        }

        public override DTSExecResult Validate(IDTSInfoEvents infoEvents)
        {
            return base.Validate(infoEvents);
        }
    }
}
