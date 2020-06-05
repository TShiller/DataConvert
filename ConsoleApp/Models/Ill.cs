using SqlSugar;

namespace ConsoleApp1.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Ill
    {
        /// <summary>
        /// 
        /// </summary>
        public Ill()
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

        private System.String _CODE;
        /// <summary>
        /// 
        /// </summary>
        public System.String CODE { get { return this._CODE; } set { this._CODE = value?.Trim(); } }

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

        private System.Byte[] _CADVICE;
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] CADVICE { get { return this._CADVICE; } set { this._CADVICE = value; } }

        private System.Byte[] _EADVICE;
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] EADVICE { get { return this._EADVICE; } set { this._EADVICE = value; } }

        private System.String _SYMLINK;
        /// <summary>
        /// 
        /// </summary>
        public System.String SYMLINK { get { return this._SYMLINK; } set { this._SYMLINK = value?.Trim(); } }

        private System.String _SYMAddtionNum;
        /// <summary>
        /// 
        /// </summary>
        public System.String SYMAddtionNum { get { return this._SYMAddtionNum; } set { this._SYMAddtionNum = value?.Trim(); } }

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

        private System.Int32? _SurLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? SurLink { get { return this._SurLink; } set { this._SurLink = value ?? default(System.Int32); } }

        private System.Int32? _HelLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? HelLink { get { return this._HelLink; } set { this._HelLink = value ?? default(System.Int32); } }

        private System.Int32? _LabLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? LabLink { get { return this._LabLink; } set { this._LabLink = value ?? default(System.Int32); } }

        private System.Int32? _NurLink;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? NurLink { get { return this._NurLink; } set { this._NurLink = value ?? default(System.Int32); } }

        private System.Int32? _Relation_Count;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? Relation_Count { get { return this._Relation_Count; } set { this._Relation_Count = value ?? default(System.Int32); } }

        private System.String _Rright;
        /// <summary>
        /// 
        /// </summary>
        public System.String Rright { get { return this._Rright; } set { this._Rright = value?.Trim(); } }

        private System.Byte[] _Photo;
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] Photo { get { return this._Photo; } set { this._Photo = value; } }

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

        private System.Boolean? _IsCIll;
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean? IsCIll { get { return this._IsCIll; } set { this._IsCIll = value ?? default(System.Boolean); } }

        private System.Boolean? _IsOften;
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean? IsOften { get { return this._IsOften; } set { this._IsOften = value ?? default(System.Boolean); } }

        private System.Boolean? _IsNotOften;
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean? IsNotOften { get { return this._IsNotOften; } set { this._IsNotOften = value ?? default(System.Boolean); } }

        private System.Boolean? _IsTeach;
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean? IsTeach { get { return this._IsTeach; } set { this._IsTeach = value ?? default(System.Boolean); } }

        private System.Boolean? _IsBase;
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean? IsBase { get { return this._IsBase; } set { this._IsBase = value ?? default(System.Boolean); } }

        private System.String _MainDep;
        /// <summary>
        /// 
        /// </summary>
        public System.String MainDep { get { return this._MainDep; } set { this._MainDep = value?.Trim(); } }

        private System.String _OthDep;
        /// <summary>
        /// 
        /// </summary>
        public System.String OthDep { get { return this._OthDep; } set { this._OthDep = value?.Trim(); } }

        private System.Boolean? _IfOpen;
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean? IfOpen { get { return this._IfOpen; } set { this._IfOpen = value ?? default(System.Boolean); } }

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

        private System.String _hXMLMemo;
        /// <summary>
        /// 
        /// </summary>
        public System.String hXMLMemo { get { return this._hXMLMemo; } set { this._hXMLMemo = value?.Trim(); } }

        private System.Boolean? _IsEme;
        /// <summary>
        /// 
        /// </summary>
        public System.Boolean? IsEme { get { return this._IsEme; } set { this._IsEme = value ?? default(System.Boolean); } }

        private System.String _nosymlink;
        /// <summary>
        /// 
        /// </summary>
        public System.String nosymlink { get { return this._nosymlink; } set { this._nosymlink = value?.Trim(); } }

        private System.Int32? _ischild;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? ischild { get { return this._ischild; } set { this._ischild = value ?? default(System.Int32); } }

        private System.Int32? _isman;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? isman { get { return this._isman; } set { this._isman = value ?? default(System.Int32); } }

        private System.Int32? _iswoman;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? iswoman { get { return this._iswoman; } set { this._iswoman = value ?? default(System.Int32); } }

        private System.Int32? _isfool;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? isfool { get { return this._isfool; } set { this._isfool = value ?? default(System.Int32); } }

        private System.String _SMEMO;
        /// <summary>
        /// 
        /// </summary>
        public System.String SMEMO { get { return this._SMEMO; } set { this._SMEMO = value?.Trim(); } }

        private System.String _XMLMEMO;
        /// <summary>
        /// 
        /// </summary>
        public System.String XMLMEMO { get { return this._XMLMEMO; } set { this._XMLMEMO = value?.Trim(); } }

        private System.Int32? _isfz;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? isfz { get { return this._isfz; } set { this._isfz = value ?? default(System.Int32); } }

        private System.Int32? _isrz;
        /// <summary>
        /// 
        /// </summary>
        public System.Int32? isrz { get { return this._isrz; } set { this._isrz = value ?? default(System.Int32); } }

        private System.String _smemo1;
        /// <summary>
        /// 
        /// </summary>
        public System.String smemo1 { get { return this._smemo1; } set { this._smemo1 = value?.Trim(); } }

        private System.String _illtype;
        /// <summary>
        /// 
        /// </summary>
        public System.String illtype { get { return this._illtype; } set { this._illtype = value?.Trim(); } }
    }
}