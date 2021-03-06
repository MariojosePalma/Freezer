namespace Gecko.WebIDL
{
    using System;
    
    
    internal class SEChannel : WebIDLBase
    {
        
        public SEChannel(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Session
        {
            get
            {
                return this.GetProperty<nsISupports>("session");
            }
        }
        
        public IntPtr OpenResponse
        {
            get
            {
                return this.GetProperty<IntPtr>("openResponse");
            }
        }
        
        public bool IsClosed
        {
            get
            {
                return this.GetProperty<bool>("isClosed");
            }
        }
        
        public SEChannelType Type
        {
            get
            {
                return this.GetProperty<SEChannelType>("type");
            }
        }
        
        public Promise < nsISupports > Transmit()
        {
            return this.CallMethod<Promise < nsISupports >>("transmit");
        }
        
        public Promise < nsISupports > Transmit(object command)
        {
            return this.CallMethod<Promise < nsISupports >>("transmit", command);
        }
        
        public Promise Close()
        {
            return this.CallMethod<Promise>("close");
        }
    }
}
