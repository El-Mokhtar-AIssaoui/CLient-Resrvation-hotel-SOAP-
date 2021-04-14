﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getIr", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleApp2.ServiceReference1.interfaceReservation getIr();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getIr", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.interfaceReservation> getIrAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getresr", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleApp2.ServiceReference1.Reservation getresr();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getresr", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.Reservation> getresrAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RechercherIdHotel", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] RechercherIdHotel(string ville, int nbEtoiles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RechercherIdHotel", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> RechercherIdHotelAsync(string ville, int nbEtoiles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/signUp", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void signUp(string Identifiant, string motDePasse);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/signUp", ReplyAction="*")]
        System.Threading.Tasks.Task signUpAsync(string Identifiant, string motDePasse);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Rechercher", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Rechercher(string ville, System.DateTime arrivee, System.DateTime depart, int prixMin, int prixMax, int nbEtoiles, int nbDePersonnes, string identifiant, string Motdepasse, int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Rechercher", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> RechercherAsync(string ville, System.DateTime arrivee, System.DateTime depart, int prixMin, int prixMax, int nbEtoiles, int nbDePersonnes, string identifiant, string Motdepasse, int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/reserFinal", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string reserFinal(int x, int id, System.DateTime arr, System.DateTime fin, string nom, string prenom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/reserFinal", ReplyAction="*")]
        System.Threading.Tasks.Task<string> reserFinalAsync(int x, int id, System.DateTime arr, System.DateTime fin, string nom, string prenom);
        
        // CODEGEN : Le paramètre 'GetImageFileResult' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetImageFile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleApp2.ServiceReference1.GetImageFileResponse GetImageFile(ConsoleApp2.ServiceReference1.GetImageFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetImageFile", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.GetImageFileResponse> GetImageFileAsync(ConsoleApp2.ServiceReference1.GetImageFileRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class interfaceReservation : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Hotel[] hotelsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public Hotel[] hotels {
            get {
                return this.hotelsField;
            }
            set {
                this.hotelsField = value;
                this.RaisePropertyChanged("hotels");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Hotel : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int nbDeChambresField;
        
        private string lieuField;
        
        private string adresseField;
        
        private string nomField;
        
        private int nbEtoilesField;
        
        private IChambre[] chambresField;
        
        private Agence agenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int nbDeChambres {
            get {
                return this.nbDeChambresField;
            }
            set {
                this.nbDeChambresField = value;
                this.RaisePropertyChanged("nbDeChambres");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string lieu {
            get {
                return this.lieuField;
            }
            set {
                this.lieuField = value;
                this.RaisePropertyChanged("lieu");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string adresse {
            get {
                return this.adresseField;
            }
            set {
                this.adresseField = value;
                this.RaisePropertyChanged("adresse");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string nom {
            get {
                return this.nomField;
            }
            set {
                this.nomField = value;
                this.RaisePropertyChanged("nom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int nbEtoiles {
            get {
                return this.nbEtoilesField;
            }
            set {
                this.nbEtoilesField = value;
                this.RaisePropertyChanged("nbEtoiles");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
        public IChambre[] chambres {
            get {
                return this.chambresField;
            }
            set {
                this.chambresField = value;
                this.RaisePropertyChanged("chambres");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public Agence agence {
            get {
                return this.agenceField;
            }
            set {
                this.agenceField = value;
                this.RaisePropertyChanged("agence");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChambreDecorateur))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChambreDouble))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChambreSimple))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Chambre))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class IChambre : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Agence : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double tauxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public double taux {
            get {
                return this.tauxField;
            }
            set {
                this.tauxField = value;
                this.RaisePropertyChanged("taux");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Reservation : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChambreDouble))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChambreSimple))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ChambreDecorateur : IChambre {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ChambreDouble : ChambreDecorateur {
        
        private int nbDePersonnesField;
        
        private int prixParNuitTTCField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int nbDePersonnes {
            get {
                return this.nbDePersonnesField;
            }
            set {
                this.nbDePersonnesField = value;
                this.RaisePropertyChanged("nbDePersonnes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int prixParNuitTTC {
            get {
                return this.prixParNuitTTCField;
            }
            set {
                this.prixParNuitTTCField = value;
                this.RaisePropertyChanged("prixParNuitTTC");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ChambreSimple : ChambreDecorateur {
        
        private int nbDePersonnesField;
        
        private int prixParNuitTTCField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int nbDePersonnes {
            get {
                return this.nbDePersonnesField;
            }
            set {
                this.nbDePersonnesField = value;
                this.RaisePropertyChanged("nbDePersonnes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int prixParNuitTTC {
            get {
                return this.prixParNuitTTCField;
            }
            set {
                this.prixParNuitTTCField = value;
                this.RaisePropertyChanged("prixParNuitTTC");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Chambre : IChambre {
        
        private int nbDePersonnesField;
        
        private string imagePathField;
        
        private int prixParNuitTTCField;
        
        private int numeroField;
        
        private Reservation[] reservationsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int nbDePersonnes {
            get {
                return this.nbDePersonnesField;
            }
            set {
                this.nbDePersonnesField = value;
                this.RaisePropertyChanged("nbDePersonnes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string imagePath {
            get {
                return this.imagePathField;
            }
            set {
                this.imagePathField = value;
                this.RaisePropertyChanged("imagePath");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int prixParNuitTTC {
            get {
                return this.prixParNuitTTCField;
            }
            set {
                this.prixParNuitTTCField = value;
                this.RaisePropertyChanged("prixParNuitTTC");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
                this.RaisePropertyChanged("numero");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
        public Reservation[] reservations {
            get {
                return this.reservationsField;
            }
            set {
                this.reservationsField = value;
                this.RaisePropertyChanged("reservations");
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetImageFile", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetImageFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int a;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int b;
        
        public GetImageFileRequest() {
        }
        
        public GetImageFileRequest(int a, int b) {
            this.a = a;
            this.b = b;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetImageFileResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetImageFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] GetImageFileResult;
        
        public GetImageFileResponse() {
        }
        
        public GetImageFileResponse(byte[] GetImageFileResult) {
            this.GetImageFileResult = GetImageFileResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : ConsoleApp2.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ConsoleApp2.ServiceReference1.WebService1Soap>, ConsoleApp2.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsoleApp2.ServiceReference1.interfaceReservation getIr() {
            return base.Channel.getIr();
        }
        
        public System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.interfaceReservation> getIrAsync() {
            return base.Channel.getIrAsync();
        }
        
        public ConsoleApp2.ServiceReference1.Reservation getresr() {
            return base.Channel.getresr();
        }
        
        public System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.Reservation> getresrAsync() {
            return base.Channel.getresrAsync();
        }
        
        public string[] RechercherIdHotel(string ville, int nbEtoiles) {
            return base.Channel.RechercherIdHotel(ville, nbEtoiles);
        }
        
        public System.Threading.Tasks.Task<string[]> RechercherIdHotelAsync(string ville, int nbEtoiles) {
            return base.Channel.RechercherIdHotelAsync(ville, nbEtoiles);
        }
        
        public void signUp(string Identifiant, string motDePasse) {
            base.Channel.signUp(Identifiant, motDePasse);
        }
        
        public System.Threading.Tasks.Task signUpAsync(string Identifiant, string motDePasse) {
            return base.Channel.signUpAsync(Identifiant, motDePasse);
        }
        
        public string[] Rechercher(string ville, System.DateTime arrivee, System.DateTime depart, int prixMin, int prixMax, int nbEtoiles, int nbDePersonnes, string identifiant, string Motdepasse, int i) {
            return base.Channel.Rechercher(ville, arrivee, depart, prixMin, prixMax, nbEtoiles, nbDePersonnes, identifiant, Motdepasse, i);
        }
        
        public System.Threading.Tasks.Task<string[]> RechercherAsync(string ville, System.DateTime arrivee, System.DateTime depart, int prixMin, int prixMax, int nbEtoiles, int nbDePersonnes, string identifiant, string Motdepasse, int i) {
            return base.Channel.RechercherAsync(ville, arrivee, depart, prixMin, prixMax, nbEtoiles, nbDePersonnes, identifiant, Motdepasse, i);
        }
        
        public string reserFinal(int x, int id, System.DateTime arr, System.DateTime fin, string nom, string prenom) {
            return base.Channel.reserFinal(x, id, arr, fin, nom, prenom);
        }
        
        public System.Threading.Tasks.Task<string> reserFinalAsync(int x, int id, System.DateTime arr, System.DateTime fin, string nom, string prenom) {
            return base.Channel.reserFinalAsync(x, id, arr, fin, nom, prenom);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp2.ServiceReference1.GetImageFileResponse ConsoleApp2.ServiceReference1.WebService1Soap.GetImageFile(ConsoleApp2.ServiceReference1.GetImageFileRequest request) {
            return base.Channel.GetImageFile(request);
        }
        
        public byte[] GetImageFile(int a, int b) {
            ConsoleApp2.ServiceReference1.GetImageFileRequest inValue = new ConsoleApp2.ServiceReference1.GetImageFileRequest();
            inValue.a = a;
            inValue.b = b;
            ConsoleApp2.ServiceReference1.GetImageFileResponse retVal = ((ConsoleApp2.ServiceReference1.WebService1Soap)(this)).GetImageFile(inValue);
            return retVal.GetImageFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.GetImageFileResponse> ConsoleApp2.ServiceReference1.WebService1Soap.GetImageFileAsync(ConsoleApp2.ServiceReference1.GetImageFileRequest request) {
            return base.Channel.GetImageFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.GetImageFileResponse> GetImageFileAsync(int a, int b) {
            ConsoleApp2.ServiceReference1.GetImageFileRequest inValue = new ConsoleApp2.ServiceReference1.GetImageFileRequest();
            inValue.a = a;
            inValue.b = b;
            return ((ConsoleApp2.ServiceReference1.WebService1Soap)(this)).GetImageFileAsync(inValue);
        }
    }
}
