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
    /// volume
    /// </summary>
    public partial interface Ivolume 
    {
        object UserObject { get; set; }

        /// <summary>
        /// Event sysVol1UpBtn.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> sysVol1UpBtn_PressEvent;

        /// <summary>
        /// Event sysVol2DownBtn.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> sysVol2DownBtn_PressEvent;

        /// <summary>
        /// Event sysVol3MuteBtn.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> sysVol3MuteBtn_PressEvent;

        /// <summary>
        /// sysVol3MuteBtn.Visibility Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void sysVol3MuteBtn_Visibility_fb(volumeBoolInputSigDelegate callback);

        /// <summary>
        /// sysVol3MuteBtn.Visibility Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void sysVol3MuteBtn_Visibility_fb(bool digital);

        /// <summary>
        /// sysVolVal$.Visibility Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void sysVolVal_Visibility_fb(volumeBoolInputSigDelegate callback);

        /// <summary>
        /// sysVolVal$.Visibility Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void sysVolVal_Visibility_fb(bool digital);

        /// <summary>
        /// sysVol1UpBtn.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void sysVol1UpBtn_Selected(volumeBoolInputSigDelegate callback);

        /// <summary>
        /// sysVol1UpBtn.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void sysVol1UpBtn_Selected(bool digital);

        /// <summary>
        /// sysVol2DownBtn.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void sysVol2DownBtn_Selected(volumeBoolInputSigDelegate callback);

        /// <summary>
        /// sysVol2DownBtn.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void sysVol2DownBtn_Selected(bool digital);

        /// <summary>
        /// sysVol3MuteBtn.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void sysVol3MuteBtn_Selected(volumeBoolInputSigDelegate callback);

        /// <summary>
        /// sysVol3MuteBtn.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void sysVol3MuteBtn_Selected(bool digital);
    }

    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="boolInputSig">The <see cref="BoolInputSig"/> joinInfo data.</param>
    /// <param name="volume">The <see cref="Ivolume"/> on which to apply the feedback.</param>
    public delegate void volumeBoolInputSigDelegate(BoolInputSig boolInputSig, Ivolume volume);

    /// <summary>
    /// volume
    /// </summary>
    internal partial class volume : Ivolume, IDisposable
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
                /// Output or Event digital joinInfo from panel to Control System: volume.sysVol1UpBtn.Press
                /// sysVol1UpBtn.Press
                /// </summary>
                public const uint sysVol1UpBtn_PressEvent = 2;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: volume.sysVol2DownBtn.Press
                /// sysVol2DownBtn.Press
                /// </summary>
                public const uint sysVol2DownBtn_PressEvent = 3;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: volume.sysVol3MuteBtn.Press
                /// sysVol3MuteBtn.Press
                /// </summary>
                public const uint sysVol3MuteBtn_PressEvent = 4;


                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: volume.sysVol3MuteBtn.Visibility_fb
                /// sysVol3MuteBtn.Visibility
                /// </summary>
                public const uint sysVol3MuteBtn_Visibility_fbState = 1;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: volume.sysVolVal.Visibility_fb
                /// sysVolVal$.Visibility
                /// </summary>
                public const uint sysVolVal_Visibility_fbState = 2;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: volume.sysVol1UpBtn.Selected
                /// sysVol1UpBtn.Selected
                /// </summary>
                public const uint sysVol1UpBtn_SelectedState = 4;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: volume.sysVol2DownBtn.Selected
                /// sysVol2DownBtn.Selected
                /// </summary>
                public const uint sysVol2DownBtn_SelectedState = 5;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: volume.sysVol3MuteBtn.Selected
                /// sysVol3MuteBtn.Selected
                /// </summary>
                public const uint sysVol3MuteBtn_SelectedState = 6;

            }
        }

        #endregion

        #region Construction and Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="volume"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        internal volume(ComponentMediator componentMediator, uint controlJoinId, uint? itemCount)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId, itemCount);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="volume"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        internal volume(ComponentMediator componentMediator, uint controlJoinId) : this(componentMediator, controlJoinId, null)
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
        /// Initializes a new instance of the <see cref="volume"/> component class.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        private void Initialize(uint controlJoinId, uint? itemCount)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 

            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.sysVol1UpBtn_PressEvent, onsysVol1UpBtn_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.sysVol2DownBtn_PressEvent, onsysVol2DownBtn_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.sysVol3MuteBtn_PressEvent, onsysVol3MuteBtn_Press);
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
        public event EventHandler<UIEventArgs> sysVol1UpBtn_PressEvent;
        private void onsysVol1UpBtn_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = sysVol1UpBtn_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> sysVol2DownBtn_PressEvent;
        private void onsysVol2DownBtn_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = sysVol2DownBtn_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> sysVol3MuteBtn_PressEvent;
        private void onsysVol3MuteBtn_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = sysVol3MuteBtn_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public void sysVol1UpBtn_Selected(volumeBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.sysVol1UpBtn_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void sysVol1UpBtn_Selected(bool digital)
        {
            sysVol1UpBtn_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void sysVol2DownBtn_Selected(volumeBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.sysVol2DownBtn_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void sysVol2DownBtn_Selected(bool digital)
        {
            sysVol2DownBtn_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void sysVol3MuteBtn_Selected(volumeBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.sysVol3MuteBtn_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void sysVol3MuteBtn_Selected(bool digital)
        {
            sysVol3MuteBtn_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void sysVol3MuteBtn_Visibility_fb(volumeBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.sysVol3MuteBtn_Visibility_fbState], this);
            }
        }

        /// <inheritdoc/>
        public void sysVol3MuteBtn_Visibility_fb(bool digital)
        {
            sysVol3MuteBtn_Visibility_fb((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void sysVolVal_Visibility_fb(volumeBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.sysVolVal_Visibility_fbState], this);
            }
        }

        /// <inheritdoc/>
        public void sysVolVal_Visibility_fb(bool digital)
        {
            sysVolVal_Visibility_fb((sig, component) => sig.BoolValue = digital);
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "volume", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            sysVol1UpBtn_PressEvent = null;
            sysVol2DownBtn_PressEvent = null;
            sysVol3MuteBtn_PressEvent = null;
        }

        #endregion
    }
}
