using SqlSugar;

namespace ConsoleApp1.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class GDFAN
    {
        /// <summary>
        /// 
        /// </summary>
        public GDFAN()
        {
        }

        private System.Int32? _IFID;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? IFID { get { return this._IFID; } set { this._IFID = value ?? default(System.Int32); } }

        private System.Int32? _FCONID;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? FCONID { get { return this._FCONID; } set { this._FCONID = value ?? default(System.Int32); } }

        private System.String _FSTR;
        /// <summary>
        /// 
        /// </summary>
        public System.String FSTR { get { return this._FSTR; } set { this._FSTR = value?.Trim(); } }

        private System.String _FTBL;
        /// <summary>
        /// 
        /// </summary>
        public System.String FTBL { get { return this._FTBL; } set { this._FTBL = value?.Trim(); } }

        private System.Boolean? _ISUSE;
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean? ISUSE { get { return this._ISUSE; } set { this._ISUSE = value ?? default(System.Boolean); } }

        private System.String _FANMEMO;
        /// <summary>
        /// 
        /// </summary>
        public System.String FANMEMO { get { return this._FANMEMO; } set { this._FANMEMO = value?.Trim(); } }

        private System.Byte[] _T1;
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] T1 { get { return this._T1; } set { this._T1 = value; } }

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

        private System.Int32 _FKEY_NO;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 FKEY_NO { get { return this._FKEY_NO; } set { this._FKEY_NO = value; } }
    }
}