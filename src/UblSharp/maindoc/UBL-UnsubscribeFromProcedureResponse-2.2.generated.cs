// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp
{
    using UblSharp.CommonAggregateComponents;
    using UblSharp.UnqualifiedDataTypes;
    using UblSharp.CommonExtensionComponents;
    
    
    /// <summary>
    /// A document sent from a Contracting Party to the Economic Operator confirming that the latter has been unsubscribed from a tendering procedure.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Details
    /// <para />ObjectClass: Unsubscribe From Procedure Response
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UnsubscribeFromProcedureResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnsubscribeFromProcedureResponse-2")]
    [System.Xml.Serialization.XmlRootAttribute("UnsubscribeFromProcedureResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnsubscribeFromProcedureResponse-2", IsNullable=false)]
    public partial class UnsubscribeFromProcedureResponseType : BaseDocument, IBaseDocument
    {
        
        private System.Collections.Generic.List<UBLExtensionType> _uBLExtensions;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlArrayAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
        public UBLExtensionType[] @__UBLExtensions
        {
            get
            {
                return _uBLExtensions?.ToArray();
            }
            set
            {
                _uBLExtensions = value == null ? null : new System.Collections.Generic.List<UBLExtensionType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UBLVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public IdentifierType @__UBLVersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public IdentifierType @__CustomizationID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public IdentifierType @__ProfileID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileExecutionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public IdentifierType @__ProfileExecutionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public IdentifierType @__ID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public IndicatorType @__CopyIndicator;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public IdentifierType @__UUID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ContractFolderID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public IdentifierType @__ContractFolderID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public TimeType @__IssueTime;
        
        private System.Collections.Generic.List<TextType> _note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public TextType[] @__Note
        {
            get
            {
                return _note?.ToArray();
            }
            set
            {
                _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UnsubscribeToProcedureDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=12)]
        public DocumentReferenceType @__UnsubscribeToProcedureDocumentReference;
        
        private System.Collections.Generic.List<SignatureType> _signature;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=13)]
        public SignatureType[] @__Signature
        {
            get
            {
                return _signature?.ToArray();
            }
            set
            {
                _signature = value == null ? null : new System.Collections.Generic.List<SignatureType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("EconomicOperatorParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=14)]
        public EconomicOperatorPartyType @__EconomicOperatorParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ContractingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=15)]
        public ContractingPartyType @__ContractingParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProcurementProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=16)]
        public ProcurementProjectType @__ProcurementProject;
        
        private System.Collections.Generic.List<ProcurementProjectLotReferenceType> _procurementProjectLotReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLotReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=17)]
        public ProcurementProjectLotReferenceType[] @__ProcurementProjectLotReference
        {
            get
            {
                return _procurementProjectLotReference?.ToArray();
            }
            set
            {
                _procurementProjectLotReference = value == null ? null : new System.Collections.Generic.List<ProcurementProjectLotReferenceType>(value);
            }
        }
        
        /// <summary>
        /// A container for all extensions present in the document.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<UBLExtensionType> IBaseDocument.UBLExtensions
        {
            get { return _uBLExtensions ?? (_uBLExtensions = new System.Collections.Generic.List<UBLExtensionType>()); }
            set { _uBLExtensions = value; }
        }

        
        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note
        {
            get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
            set { _note = value; }
        }

        
        /// <summary>
        /// A signature applied to this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Signature
        /// <para />AssociatedObjectClass: Signature
        /// <para />RepresentationTerm: Signature
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<SignatureType> IBaseDocument.Signature
        {
            get { return _signature ?? (_signature = new System.Collections.Generic.List<SignatureType>()); }
            set { _signature = value; }
        }

        
        /// <summary>
        /// One of the procurement project lots into which this contract can be split.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Procurement Project Lot Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Procurement Project Lot Reference
        /// <para />AssociatedObjectClass: Procurement Project Lot Reference
        /// <para />RepresentationTerm: Procurement Project Lot Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ProcurementProjectLotReferenceType> ProcurementProjectLotReference
        {
            get { return _procurementProjectLotReference ?? (_procurementProjectLotReference = new System.Collections.Generic.List<ProcurementProjectLotReferenceType>()); }
            set { _procurementProjectLotReference = value; }
        }

        
        /// <summary>
        /// The earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: UBL Version Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UBLVersionID
        {
            get
            {
                if (__UBLVersionID == null) { __UBLVersionID = new IdentifierType(); }
                return __UBLVersionID;
            }
            set
            {
                __UBLVersionID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined customization of UBL for a specific use.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Customization Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.CustomizationID
        {
            get
            {
                if (__CustomizationID == null) { __CustomizationID = new IdentifierType(); }
                return __CustomizationID;
            }
            set
            {
                __CustomizationID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined profile of the customization of UBL being used.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Profile Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileID
        {
            get
            {
                if (__ProfileID == null) { __ProfileID = new IdentifierType(); }
                return __ProfileID;
            }
            set
            {
                __ProfileID = value;
            }
        }

        
        /// <summary>
        /// Identifies an instance of executing a profile, to associate all transactions in a collaboration.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Profile Execution Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileExecutionID
        {
            get
            {
                if (__ProfileExecutionID == null) { __ProfileExecutionID = new IdentifierType(); }
                return __ProfileExecutionID;
            }
            set
            {
                __ProfileExecutionID = value;
            }
        }

        
        /// <summary>
        /// An identifier for this document, assigned by the sender.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ID
        {
            get
            {
                if (__ID == null) { __ID = new IdentifierType(); }
                return __ID;
            }
            set
            {
                __ID = value;
            }
        }

        
        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTermQualifier: Copy
        /// <para />PropertyTerm: Indicator
        /// <para />RepresentationTerm: Indicator
        /// <para />DataType: Indicator. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IndicatorType CopyIndicator
        {
            get
            {
                if (__CopyIndicator == null) { __CopyIndicator = new IndicatorType(); }
                return __CopyIndicator;
            }
            set
            {
                __CopyIndicator = value;
            }
        }

        
        /// <summary>
        /// A universally unique identifier for an instance of this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: UUID
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UUID
        {
            get
            {
                if (__UUID == null) { __UUID = new IdentifierType(); }
                return __UUID;
            }
            set
            {
                __UUID = value;
            }
        }

        
        /// <summary>
        /// An identifier, assigned by the sender, for the process file (i.e., record) to which this document belongs.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Contract Folder Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Contract Folder Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType ContractFolderID
        {
            get
            {
                if (__ContractFolderID == null) { __ContractFolderID = new IdentifierType(); }
                return __ContractFolderID;
            }
            set
            {
                __ContractFolderID = value;
            }
        }

        
        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType IssueDate
        {
            get
            {
                if (__IssueDate == null) { __IssueDate = new DateType(); }
                return __IssueDate;
            }
            set
            {
                __IssueDate = value;
            }
        }

        
        /// <summary>
        /// The time, assigned by the sender, at which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType IssueTime
        {
            get
            {
                if (__IssueTime == null) { __IssueTime = new TimeType(); }
                return __IssueTime;
            }
            set
            {
                __IssueTime = value;
            }
        }

        
        /// <summary>
        /// A reference to the unsubscribe to procedure document associated with this confirmation.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Unsubscribe To Procedure_ Document Reference. Document Reference
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTermQualifier: Unsubscribe To Procedure
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DocumentReferenceType UnsubscribeToProcedureDocumentReference
        {
            get
            {
                if (__UnsubscribeToProcedureDocumentReference == null) { __UnsubscribeToProcedureDocumentReference = new DocumentReferenceType(); }
                return __UnsubscribeToProcedureDocumentReference;
            }
            set
            {
                __UnsubscribeToProcedureDocumentReference = value;
            }
        }

        
        /// <summary>
        /// The Economic Operator receiving this unsubscribe to procedure confirmation.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Economic Operator Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Economic Operator Party
        /// <para />AssociatedObjectClass: Economic Operator Party
        /// <para />RepresentationTerm: Economic Operator Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public EconomicOperatorPartyType EconomicOperatorParty
        {
            get
            {
                if (__EconomicOperatorParty == null) { __EconomicOperatorParty = new EconomicOperatorPartyType(); }
                return __EconomicOperatorParty;
            }
            set
            {
                __EconomicOperatorParty = value;
            }
        }

        
        /// <summary>
        /// The Contracting Party.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Contracting Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Contracting Party
        /// <para />AssociatedObjectClass: Contracting Party
        /// <para />RepresentationTerm: Contracting Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ContractingPartyType ContractingParty
        {
            get
            {
                if (__ContractingParty == null) { __ContractingParty = new ContractingPartyType(); }
                return __ContractingParty;
            }
            set
            {
                __ContractingParty = value;
            }
        }

        
        /// <summary>
        /// An overall definition of this procurement project.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Unsubscribe From Procedure Response. Procurement Project
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Unsubscribe From Procedure Response
        /// <para />PropertyTerm: Procurement Project
        /// <para />AssociatedObjectClass: Procurement Project
        /// <para />RepresentationTerm: Procurement Project
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ProcurementProjectType ProcurementProject
        {
            get
            {
                if (__ProcurementProject == null) { __ProcurementProject = new ProcurementProjectType(); }
                return __ProcurementProject;
            }
            set
            {
                __ProcurementProject = value;
            }
        }

    }
}
