using SqlSugar;

namespace ConsoleApp1.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class IFStr
    {
        /// <summary>
        /// 
        /// </summary>
        public IFStr()
        {
        }

        private System.String _ATBL;
        /// <summary>
        /// 
        /// </summary>
        public System.String ATBL { get { return this._ATBL; } set { this._ATBL = value?.Trim(); } }

        private System.String _BTBL;
        /// <summary>
        /// 
        /// </summary>
        public System.String BTBL { get { return this._BTBL; } set { this._BTBL = value?.Trim(); } }

        private System.Int32? _AKEY_NO;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? AKEY_NO { get { return this._AKEY_NO; } set { this._AKEY_NO = value ?? default(System.Int32); } }

        private System.Int32? _BKEY_NO;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? BKEY_NO { get { return this._BKEY_NO; } set { this._BKEY_NO = value ?? default(System.Int32); } }

        private System.String _ACV;
        /// <summary>
        /// 
        /// </summary>
        public System.String ACV { get { return this._ACV; } set { this._ACV = value?.Trim(); } }

        private System.String _BCV;
        /// <summary>
        /// 
        /// </summary>
        public System.String BCV { get { return this._BCV; } set { this._BCV = value?.Trim(); } }

        private System.String _IFSTR;
        /// <summary>
        /// 
        /// </summary>
        public System.String IFSTR { get { return this._IFSTR; } set { this._IFSTR = value?.Trim(); } }

        private System.DateTime? _WRDATE;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? WRDATE { get { return this._WRDATE; } set { this._WRDATE = value ?? default(System.DateTime); } }

        private System.String _memo;
        /// <summary>
        /// 
        /// </summary>
        public System.String memo { get { return this._memo; } set { this._memo = value?.Trim(); } }

        private System.Int32? _KEYNO;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? KEYNO { get { return this._KEYNO; } set { this._KEYNO = value ?? default(System.Int32); } }
    }
}