﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BinaryConverterServiceClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBinaryConverterService")]
    public interface IBinaryConverterService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBinaryConverterService/GetBinary", ReplyAction="http://tempuri.org/IBinaryConverterService/GetBinaryResponse")]
        string GetBinary(int value);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IBinaryConverterService/GetBinary", ReplyAction="http://tempuri.org/IBinaryConverterService/GetBinaryResponse")]
        System.IAsyncResult BeginGetBinary(int value, System.AsyncCallback callback, object asyncState);
        
        string EndGetBinary(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBinaryConverterService/GetOneCount", ReplyAction="http://tempuri.org/IBinaryConverterService/GetOneCountResponse")]
        int GetOneCount(int value);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IBinaryConverterService/GetOneCount", ReplyAction="http://tempuri.org/IBinaryConverterService/GetOneCountResponse")]
        System.IAsyncResult BeginGetOneCount(int value, System.AsyncCallback callback, object asyncState);
        
        int EndGetOneCount(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBinaryConverterServiceChannel : BinaryConverterServiceClient.ServiceReference1.IBinaryConverterService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetBinaryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetBinaryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetOneCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetOneCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BinaryConverterServiceClient : System.ServiceModel.ClientBase<BinaryConverterServiceClient.ServiceReference1.IBinaryConverterService>, BinaryConverterServiceClient.ServiceReference1.IBinaryConverterService {
        
        private BeginOperationDelegate onBeginGetBinaryDelegate;
        
        private EndOperationDelegate onEndGetBinaryDelegate;
        
        private System.Threading.SendOrPostCallback onGetBinaryCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetOneCountDelegate;
        
        private EndOperationDelegate onEndGetOneCountDelegate;
        
        private System.Threading.SendOrPostCallback onGetOneCountCompletedDelegate;
        
        public BinaryConverterServiceClient() {
        }
        
        public BinaryConverterServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BinaryConverterServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BinaryConverterServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BinaryConverterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetBinaryCompletedEventArgs> GetBinaryCompleted;
        
        public event System.EventHandler<GetOneCountCompletedEventArgs> GetOneCountCompleted;
        
        public string GetBinary(int value) {
            return base.Channel.GetBinary(value);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetBinary(int value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetBinary(value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetBinary(System.IAsyncResult result) {
            return base.Channel.EndGetBinary(result);
        }
        
        private System.IAsyncResult OnBeginGetBinary(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int value = ((int)(inValues[0]));
            return this.BeginGetBinary(value, callback, asyncState);
        }
        
        private object[] OnEndGetBinary(System.IAsyncResult result) {
            string retVal = this.EndGetBinary(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetBinaryCompleted(object state) {
            if ((this.GetBinaryCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetBinaryCompleted(this, new GetBinaryCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetBinaryAsync(int value) {
            this.GetBinaryAsync(value, null);
        }
        
        public void GetBinaryAsync(int value, object userState) {
            if ((this.onBeginGetBinaryDelegate == null)) {
                this.onBeginGetBinaryDelegate = new BeginOperationDelegate(this.OnBeginGetBinary);
            }
            if ((this.onEndGetBinaryDelegate == null)) {
                this.onEndGetBinaryDelegate = new EndOperationDelegate(this.OnEndGetBinary);
            }
            if ((this.onGetBinaryCompletedDelegate == null)) {
                this.onGetBinaryCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetBinaryCompleted);
            }
            base.InvokeAsync(this.onBeginGetBinaryDelegate, new object[] {
                        value}, this.onEndGetBinaryDelegate, this.onGetBinaryCompletedDelegate, userState);
        }
        
        public int GetOneCount(int value) {
            return base.Channel.GetOneCount(value);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetOneCount(int value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetOneCount(value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int EndGetOneCount(System.IAsyncResult result) {
            return base.Channel.EndGetOneCount(result);
        }
        
        private System.IAsyncResult OnBeginGetOneCount(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int value = ((int)(inValues[0]));
            return this.BeginGetOneCount(value, callback, asyncState);
        }
        
        private object[] OnEndGetOneCount(System.IAsyncResult result) {
            int retVal = this.EndGetOneCount(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetOneCountCompleted(object state) {
            if ((this.GetOneCountCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetOneCountCompleted(this, new GetOneCountCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetOneCountAsync(int value) {
            this.GetOneCountAsync(value, null);
        }
        
        public void GetOneCountAsync(int value, object userState) {
            if ((this.onBeginGetOneCountDelegate == null)) {
                this.onBeginGetOneCountDelegate = new BeginOperationDelegate(this.OnBeginGetOneCount);
            }
            if ((this.onEndGetOneCountDelegate == null)) {
                this.onEndGetOneCountDelegate = new EndOperationDelegate(this.OnEndGetOneCount);
            }
            if ((this.onGetOneCountCompletedDelegate == null)) {
                this.onGetOneCountCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetOneCountCompleted);
            }
            base.InvokeAsync(this.onBeginGetOneCountDelegate, new object[] {
                        value}, this.onEndGetOneCountDelegate, this.onGetOneCountCompletedDelegate, userState);
        }
    }
}
