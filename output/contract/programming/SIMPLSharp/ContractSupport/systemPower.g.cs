//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CrestronConstruct.
//     AppHost:     2.101.8.0
//     UI Plugin:   1.3701.9.0
//
//     Project:     MicrosoftTeamsDemo
//     Version:     1.0.0.0
//     Sdk:         CH5:2.11.1.2
//     Strategy:    Classic
//     IndexOnly:   False
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using Crestron.SimplSharpPro.DeviceSupport;
using MicrosoftTeamsDemo;

namespace MicrosoftTeamsDemo
{

    /// <summary>
    /// systemPower
    /// </summary>
    public partial interface IsystemPower 
    {
        object UserObject { get; set; }

        /// <summary>
        /// Event shutdownCancel.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> shutdownCancel_PressEvent;

        /// <summary>
        /// Event shutdownConfirm.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> shutdownConfirm_PressEvent;

        /// <summary>
        /// Event shutdownTimeGauge.Lower Touch (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> shutdownTimeGauge_LowerTouchEvent;

        /// <summary>
        /// Event shutdownDismiss.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> shutdownDismiss_PressEvent;

        /// <summary>
        /// shutdownCancel.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void shutdownCancel_Selected(systemPowerBoolInputSigDelegate callback);

        /// <summary>
        /// shutdownCancel.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void shutdownCancel_Selected(bool digital);

        /// <summary>
        /// shutdownConfirm.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void shutdownConfirm_Selected(systemPowerBoolInputSigDelegate callback);

        /// <summary>
        /// shutdownConfirm.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void shutdownConfirm_Selected(bool digital);

        /// <summary>
        /// shutdownDismiss.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void shutdownDismiss_Selected(systemPowerBoolInputSigDelegate callback);

        /// <summary>
        /// shutdownDismiss.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void shutdownDismiss_Selected(bool digital);

        /// <summary>
        /// shutdownTimeGauge.Lower Touch fb Feedback
        /// </summary>
        /// <param name="callback">The ushort delegate to update the panel.</param>
        void shutdownTimeGauge_LowerTouchfb(systemPowerUShortInputSigDelegate callback);

        /// <summary>
        /// shutdownTimeGauge.Lower Touch fb Feedback
        /// </summary>
        /// <param name="callback">The ushort analog to update the panel.</param>
        void shutdownTimeGauge_LowerTouchfb(ushort analog);

        /// <summary>
        /// shutdownTimeGauge.Lower Touch fb Feedback
        /// </summary>
        /// <param name="callback">The short analog to update the panel.</param>
        void shutdownTimeGauge_LowerTouchfb(short analog);
    }

    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="boolInputSig">The <see cref="BoolInputSig"/> joinInfo data.</param>
    /// <param name="systempower">The <see cref="IsystemPower"/> on which to apply the feedback.</param>
    public delegate void systemPowerBoolInputSigDelegate(BoolInputSig boolInputSig, IsystemPower systempower);
    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="uShortInputSig">The <see cref="UShortInputSig"/> joinInfo data.</param>
    /// <param name="systempower">The <see cref="IsystemPower"/> on which to apply the feedback.</param>
    public delegate void systemPowerUShortInputSigDelegate(UShortInputSig uShortInputSig, IsystemPower systempower);

    /// <summary>
    /// systemPower
    /// </summary>
    internal partial class systemPower : IsystemPower, IDisposable
    {
        #region Standard CH5 Component members

        private ComponentMediator ComponentMediator { get; set; }

        public object UserObject { get; set; }

        /// <summary>
        /// Gets the ControlJoinId a.k.a. SmartObjectId.  This Id identifies the extender symbol.
        /// </summary>
        public uint ControlJoinId { get; private set; }

        private IList<BasicTriListWithSmartObject> _devices;

        /// <summary>
        /// Gets the list of devices.
        /// </summary>
        public IList<BasicTriListWithSmartObject> Devices { get { return _devices; } }

        #endregion

        #region Joins

        private static class Joins
        {
            /// <summary>
            /// Digital signals,
            /// </summary>
            internal static class Booleans
            {
                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: systemPower.shutdownCancel.Press
                /// shutdownCancel.Press
                /// </summary>
                public const uint shutdownCancel_PressEvent = 3;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: systemPower.shutdownConfirm.Press
                /// shutdownConfirm.Press
                /// </summary>
                public const uint shutdownConfirm_PressEvent = 4;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: systemPower.shutdownDismiss.Press
                /// shutdownDismiss.Press
                /// </summary>
                public const uint shutdownDismiss_PressEvent = 5;


                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: systemPower.shutdownCancel.Selected
                /// shutdownCancel.Selected
                /// </summary>
                public const uint shutdownCancel_SelectedState = 3;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: systemPower.shutdownConfirm.Selected
                /// shutdownConfirm.Selected
                /// </summary>
                public const uint shutdownConfirm_SelectedState = 4;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: systemPower.shutdownDismiss.Selected
                /// shutdownDismiss.Selected
                /// </summary>
                public const uint shutdownDismiss_SelectedState = 5;

            }
            /// <summary>
            /// Analog signals.
            /// </summary>
            internal static class Numerics
            {
                /// <summary>
                /// Output or Event analog joinInfo from panel to Control System: systemPower.shutdownTimeGauge.LowerTouch
                /// shutdownTimeGauge.Lower Touch
                /// </summary>
                public const uint shutdownTimeGauge_LowerTouchEvent = 4;


                /// <summary>
                /// Input or Feedback analog joinInfo from Control System to panel: systemPower.shutdownTimeGauge.LowerTouchfb
                /// shutdownTimeGauge.Lower Touch fb
                /// </summary>
                public const uint shutdownTimeGauge_LowerTouchfbState = 4;

            }
        }

        #endregion

        #region Construction and Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="systemPower"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        internal systemPower(ComponentMediator componentMediator, uint controlJoinId, uint? itemCount)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId, itemCount);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="systemPower"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        internal systemPower(ComponentMediator componentMediator, uint controlJoinId) : this(componentMediator, controlJoinId, null)
        {
        }

        /// <summary>
        /// Initializes a new instance with default itemCount.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        private void Initialize(uint controlJoinId)
        {
            Initialize(controlJoinId, null);
        }

        private Dictionary<string, Indexes> _indexLookup = new Dictionary<string, Indexes>();

        /// <summary>
        /// Initializes a new instance of the <see cref="systemPower"/> component class.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        private void Initialize(uint controlJoinId, uint? itemCount)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 

            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.shutdownCancel_PressEvent, onshutdownCancel_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.shutdownConfirm_PressEvent, onshutdownConfirm_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.shutdownDismiss_PressEvent, onshutdownDismiss_Press);
            ComponentMediator.ConfigureNumericEvent(controlJoinId, Joins.Numerics.shutdownTimeGauge_LowerTouchEvent, onshutdownTimeGauge_LowerTouch);
        }

        public void AddDevice(BasicTriListWithSmartObject device)
        {
            Devices.Add(device);
            ComponentMediator.HookSmartObjectEvents(device.SmartObjects[ControlJoinId]);
        }

        public void RemoveDevice(BasicTriListWithSmartObject device)
        {
            Devices.Remove(device);
            ComponentMediator.UnHookSmartObjectEvents(device.SmartObjects[ControlJoinId]);
        }

        #endregion

        #region CH5 Contract

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> shutdownCancel_PressEvent;
        private void onshutdownCancel_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = shutdownCancel_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> shutdownConfirm_PressEvent;
        private void onshutdownConfirm_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = shutdownConfirm_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> shutdownTimeGauge_LowerTouchEvent;
        private void onshutdownTimeGauge_LowerTouch(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = shutdownTimeGauge_LowerTouchEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> shutdownDismiss_PressEvent;
        private void onshutdownDismiss_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = shutdownDismiss_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public void shutdownCancel_Selected(systemPowerBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.shutdownCancel_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void shutdownCancel_Selected(bool digital)
        {
            shutdownCancel_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void shutdownConfirm_Selected(systemPowerBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.shutdownConfirm_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void shutdownConfirm_Selected(bool digital)
        {
            shutdownConfirm_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void shutdownDismiss_Selected(systemPowerBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.shutdownDismiss_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void shutdownDismiss_Selected(bool digital)
        {
            shutdownDismiss_Selected((sig, component) => sig.BoolValue = digital);
        }

        /// <inheritdoc/>
        public void shutdownTimeGauge_LowerTouchfb(systemPowerUShortInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].UShortInput[Joins.Numerics.shutdownTimeGauge_LowerTouchfbState], this);
            }
        }

        /// <inheritdoc/>
        public void shutdownTimeGauge_LowerTouchfb(ushort analog)
        {
            shutdownTimeGauge_LowerTouchfb((sig, component) => sig.UShortValue = analog);
        }

        /// <inheritdoc/>
        public void shutdownTimeGauge_LowerTouchfb(short analog)
        {
            shutdownTimeGauge_LowerTouchfb((sig, component) => sig.ShortValue = analog);
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "systemPower", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            shutdownCancel_PressEvent = null;
            shutdownConfirm_PressEvent = null;
            shutdownTimeGauge_LowerTouchEvent = null;
            shutdownDismiss_PressEvent = null;
        }

        #endregion
    }
}
