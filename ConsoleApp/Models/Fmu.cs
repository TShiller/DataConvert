using SqlSugar;

namespace ConsoleApp1.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Fmu
    {
        /// <summary>
        /// 
        /// </summary>
        public Fmu()
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

        private System.Int32? _MedLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? MedLink { get { return this._MedLink; } set { this._MedLink = value ?? default(System.Int32); } }

        private System.Int32? _OpeLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? OpeLink { get { return this._OpeLink; } set { this._OpeLink = value ?? default(System.Int32); } }

        private System.Int32? _PreLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? PreLink { get { return this._PreLink; } set { this._PreLink = value ?? default(System.Int32); } }

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

        private System.Boolean? _JY;
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean? JY { get { return this._JY; } set { this._JY = value ?? default(System.Boolean); } }
    }
}