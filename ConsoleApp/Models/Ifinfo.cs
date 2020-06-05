using SqlSugar;

namespace ConsoleApp1.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class IFINFO
    {
        /// <summary>
        /// 
        /// </summary>
        public IFINFO()
        {
        }

        private System.Int32? _CONID;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? CONID { get { return this._CONID; } set { this._CONID = value ?? default(System.Int32); } }

        private System.String _TBL;
        /// <summary>
        /// 
        /// </summary>
        public System.String TBL { get { return this._TBL; } set { this._TBL = value?.Trim(); } }

        private System.Int32 _IFID;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 IFID { get { return this._IFID; } set { this._IFID = value; } }

        private System.String _IFSTR;
        /// <summary>
        /// 
        /// </summary>
        public System.String IFSTR { get { return this._IFSTR; } set { this._IFSTR = value?.Trim(); } }

        private System.String _IFMEMO;
        /// <summary>
        /// 
        /// </summary>
        public System.String IFMEMO { get { return this._IFMEMO; } set { this._IFMEMO = value?.Trim(); } }

        private System.Boolean? _ISUSE;
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean? ISUSE { get { return this._ISUSE; } set { this._ISUSE = value ?? default(System.Boolean); } }

        private System.Int32? _IFNO;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? IFNO { get { return this._IFNO; } set { this._IFNO = value ?? default(System.Int32); } }

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

        private System.String _T3;
        /// <summary>
        /// 
        /// </summary>
        public System.String T3 { get { return this._T3; } set { this._T3 = value?.Trim(); } }

        private System.Int32 _inx;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 inx { get { return this._inx; } set { this._inx = value; } }

        private System.Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 ID { get { return this._ID; } set { this._ID = value; } }

        private System.DateTime? _WRDATE;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? WRDATE { get { return this._WRDATE; } set { this._WRDATE = value ?? default(System.DateTime); } }

        private System.Int32? _op;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? op { get { return this._op; } set { this._op = value ?? default(System.Int32); } }

        private System.String _eng;
        /// <summary>
        /// 
        /// </summary>
        public System.String eng { get { return this._eng; } set { this._eng = value?.Trim(); } }
    }
}