using SqlSugar;

namespace ConsoleApp1.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class GDDRU
    {
        /// <summary>
        /// 
        /// </summary>
        public GDDRU()
        {
        }

        private System.Int32? _IFID;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? IFID { get { return this._IFID; } set { this._IFID = value ?? default(System.Int32); } }

        private System.Int32? _DRUCONID;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? DRUCONID { get { return this._DRUCONID; } set { this._DRUCONID = value ?? default(System.Int32); } }

        private System.Int32? _FCONID;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? FCONID { get { return this._FCONID; } set { this._FCONID = value ?? default(System.Int32); } }

        private System.String _DRUNAME;
        /// <summary>
        /// 
        /// </summary>
        public System.String DRUNAME { get { return this._DRUNAME; } set { this._DRUNAME = value?.Trim(); } }

        private System.String _DRUTBL;
        /// <summary>
        /// 
        /// </summary>
        public System.String DRUTBL { get { return this._DRUTBL; } set { this._DRUTBL = value?.Trim(); } }

        private System.Boolean? _ISUSE;
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean? ISUSE { get { return this._ISUSE; } set { this._ISUSE = value ?? default(System.Boolean); } }

        private System.String _DRUMEMO;
        /// <summary>
        /// 
        /// </summary>
        public System.String DRUMEMO { get { return this._DRUMEMO; } set { this._DRUMEMO = value?.Trim(); } }

        private System.String _T1;
        /// <summary>
        /// 
        /// </summary>
        public System.String T1 { get { return this._T1; } set { this._T1 = value?.Trim(); } }

        private System.String _T2;
        /// <summary>
        /// 
        /// </summary>
        public System.String T2 { get { return this._T2; } set { this._T2 = value?.Trim(); } }

        private System.Int32 _id;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id { get { return this._id; } set { this._id = value; } }

        private System.Int32 _INX;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 INX { get { return this._INX; } set { this._INX = value; } }

        private System.Int32? _DRUKey_No;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? DRUKey_No { get { return this._DRUKey_No; } set { this._DRUKey_No = value ?? default(System.Int32); } }
    }
}