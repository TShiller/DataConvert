using SqlSugar;

namespace ConsoleApp1.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Ope
    {
        /// <summary>
        /// 
        /// </summary>
        public Ope()
        {
        }

        private System.Int32 _KEY_NO;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 KEY_NO { get { return this._KEY_NO; } set { this._KEY_NO = value; } }

        private System.String _CVOCABLE;
        /// <summary>
        /// 
        /// </summary>
        public System.String CVOCABLE { get { return this._CVOCABLE; } set { this._CVOCABLE = value?.Trim(); } }

        private System.String _EVOCABLE;
        /// <summary>
        /// 
        /// </summary>
        public System.String EVOCABLE { get { return this._EVOCABLE; } set { this._EVOCABLE = value?.Trim(); } }

        private System.Byte[] _CMEMO;
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] CMEMO { get { return this._CMEMO; } set { this._CMEMO = value; } }

        private System.Byte[] _EMEMO;
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] EMEMO { get { return this._EMEMO; } set { this._EMEMO = value; } }

        private System.Int32? _IllLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? IllLink { get { return this._IllLink; } set { this._IllLink = value ?? default(System.Int32); } }

        private System.Int32? _TreLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? TreLink { get { return this._TreLink; } set { this._TreLink = value ?? default(System.Int32); } }

        private System.Int32? _DruLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? DruLink { get { return this._DruLink; } set { this._DruLink = value ?? default(System.Int32); } }

        private System.Int32? _FmuLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? FmuLink { get { return this._FmuLink; } set { this._FmuLink = value ?? default(System.Int32); } }

        private System.Int32? _HerLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? HerLink { get { return this._HerLink; } set { this._HerLink = value ?? default(System.Int32); } }

        private System.Int32? _AidLInk;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? AidLInk { get { return this._AidLInk; } set { this._AidLInk = value ?? default(System.Int32); } }

        private System.Int32? _AnaLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? AnaLink { get { return this._AnaLink; } set { this._AnaLink = value ?? default(System.Int32); } }

        private System.Int32? _Relation_Count;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? Relation_Count { get { return this._Relation_Count; } set { this._Relation_Count = value ?? default(System.Int32); } }

        private System.Int32? _UseLevel;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? UseLevel { get { return this._UseLevel; } set { this._UseLevel = value ?? default(System.Int32); } }

        private System.String _CXMLMemo;
        /// <summary>
        /// 
        /// </summary>
        public System.String CXMLMemo { get { return this._CXMLMemo; } set { this._CXMLMemo = value?.Trim(); } }

        private System.Int16? _IsAcu;
        /// <summary>
        /// 
        /// </summary>
        public System.Int16? IsAcu { get { return this._IsAcu; } set { this._IsAcu = value ?? default(System.Int16); } }

        private System.String _HKVOCABLE;
        /// <summary>
        /// 
        /// </summary>
        public System.String HKVOCABLE { get { return this._HKVOCABLE; } set { this._HKVOCABLE = value?.Trim(); } }

        private System.Int32 _CONID;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 CONID { get { return this._CONID; } set { this._CONID = value; } }

        private System.String _HXMLMemo;
        /// <summary>
        /// 
        /// </summary>
        public System.String HXMLMemo { get { return this._HXMLMemo; } set { this._HXMLMemo = value?.Trim(); } }
    }
}