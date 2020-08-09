using System;
using System.Collections.ObjectModel;

namespace DryingHouse.Core.Domain
{
    public class ProgramFunctionMaster : Base
    {
        #region Fields
        public string Id { get; set; }
        public string ProgramName { get; set; }
        public string FunctionName { get; set; }
        public string Explanation { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
