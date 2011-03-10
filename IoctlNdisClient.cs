using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ManagedWifi;

namespace MetaGeek.IoctlNdis
{
    public class IoctlNdisClient
    {
        #region Fields

        #endregion Fields

        #region Properties

        public WlanInterface[] Interfaces
        {
            get; set;
        }

        #endregion Properties

        #region Event Related

        #region Events

        public event EventHandler<InterfaceNotificationEventsArgs> InterfaceArrivedEvent;

        public event EventHandler<InterfaceNotificationEventsArgs> InterfaceRemovedEvent;

        #endregion Events

        #region Invoke Methods

        protected virtual void InvokeInterfaceArrivedEvent(InterfaceNotificationEventsArgs e)
        {
            if (InterfaceArrivedEvent != null)
            {
                InterfaceArrivedEvent(this, e);
            }
        }

        protected virtual void InvokeInterfaceRemovedEvent(InterfaceNotificationEventsArgs e)
        {
            if (InterfaceRemovedEvent != null)
            {
                InterfaceRemovedEvent(this, e);
            }
        }

        #endregion Invoke Methods

        #endregion Event Related

        #region Constructors

        public IoctlNdisClient()
        {
        }

        #endregion Constructors

        #region Public Methods

        #endregion Public Methods

        #region Private Methods

        #endregion Private Methods
    }
}