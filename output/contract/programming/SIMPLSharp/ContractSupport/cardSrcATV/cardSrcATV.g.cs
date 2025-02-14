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

namespace MicrosoftTeamsDemo.cardSrcATV
{

    /// <summary>
    /// cardSrcATV
    /// </summary>
    public partial interface IcardSrcATV 
    {
        object UserObject { get; set; }

        /// <summary>
        /// Event atvBack.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> atvBack_PressEvent;

        /// <summary>
        /// Event atvPlay.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> atvPlay_PressEvent;

        /// <summary>
        /// Event navReturn.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> navReturn_PressEvent;

        /// <summary>
        /// atvBack.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void atvBack_Selected(cardSrcATVBoolInputSigDelegate callback);

        /// <summary>
        /// atvBack.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void atvBack_Selected(bool digital);

        /// <summary>
        /// atvPlay.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void atvPlay_Selected(cardSrcATVBoolInputSigDelegate callback);

        /// <summary>
        /// atvPlay.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void atvPlay_Selected(bool digital);

        /// <summary>
        /// navReturn.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void navReturn_Selected(cardSrcATVBoolInputSigDelegate callback);

        /// <summary>
        /// navReturn.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void navReturn_Selected(bool digital);

        /// <summary>
        /// atvBack.Icon URL Feedback
        /// </summary>
        /// <param name="callback">The <see cref="string"/> delegate to update the panel.</param>
        void atvBack_IconURL(cardSrcATVStringInputSigDelegate callback);

        /// <summary>
        /// atvBack.Icon URL Feedback
        /// </summary>
        /// <param name="serial">The <see cref="string"/> to update the panel.</param>
        void atvBack_IconURL(string serial);

        /// <summary>
        /// atvPlay.Icon URL Feedback
        /// </summary>
        /// <param name="callback">The <see cref="string"/> delegate to update the panel.</param>
        void atvPlay_IconURL(cardSrcATVStringInputSigDelegate callback);

        /// <summary>
        /// atvPlay.Icon URL Feedback
        /// </summary>
        /// <param name="serial">The <see cref="string"/> to update the panel.</param>
        void atvPlay_IconURL(string serial);

        /// <summary>
        /// ComplexComponent atvDpad
        /// </summary>
        MicrosoftTeamsDemo.cardSrcATV.IatvDpad atvDpad { get; }
    }

    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="boolInputSig">The <see cref="BoolInputSig"/> joinInfo data.</param>
    /// <param name="cardsrcatv">The <see cref="IcardSrcATV"/> on which to apply the feedback.</param>
    public delegate void cardSrcATVBoolInputSigDelegate(BoolInputSig boolInputSig, IcardSrcATV cardsrcatv);
    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="stringInputSig">The <see cref="StringInputSig"/> joinInfo data.</param>
    /// <param name="cardsrcatv">The <see cref="IcardSrcATV"/> on which to apply the feedback.</param>
    public delegate void cardSrcATVStringInputSigDelegate(StringInputSig stringInputSig, IcardSrcATV cardsrcatv);

    /// <summary>
    /// cardSrcATV
    /// </summary>
    internal partial class cardSrcATV : IcardSrcATV, IDisposable
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
                /// Output or Event digital joinInfo from panel to Control System: cardSrcATV.atvBack.Press
                /// atvBack.Press
                /// </summary>
                public const uint atvBack_PressEvent = 3;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: cardSrcATV.atvPlay.Press
                /// atvPlay.Press
                /// </summary>
                public const uint atvPlay_PressEvent = 4;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: cardSrcATV.navReturn.Press
                /// navReturn.Press
                /// </summary>
                public const uint navReturn_PressEvent = 5;


                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: cardSrcATV.atvBack.Selected
                /// atvBack.Selected
                /// </summary>
                public const uint atvBack_SelectedState = 3;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: cardSrcATV.atvPlay.Selected
                /// atvPlay.Selected
                /// </summary>
                public const uint atvPlay_SelectedState = 4;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: cardSrcATV.navReturn.Selected
                /// navReturn.Selected
                /// </summary>
                public const uint navReturn_SelectedState = 5;

            }
            /// <summary>
            /// Serial signals.
            /// </summary>
            internal static class Strings
            {

                /// <summary>
                /// Input or Feedback serial joinInfo from Control System to panel: cardSrcATV.atvBack.IconURL
                /// atvBack.Icon URL
                /// </summary>
                public const uint atvBack_IconURLState = 6;
                /// <summary>
                /// Input or Feedback serial joinInfo from Control System to panel: cardSrcATV.atvPlay.IconURL
                /// atvPlay.Icon URL
                /// </summary>
                public const uint atvPlay_IconURLState = 7;
            }
        }

        #endregion

        #region Construction and Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="cardSrcATV"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        internal cardSrcATV(ComponentMediator componentMediator, uint controlJoinId, uint? itemCount)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId, itemCount);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="cardSrcATV"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        internal cardSrcATV(ComponentMediator componentMediator, uint controlJoinId) : this(componentMediator, controlJoinId, null)
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
        /// Initializes a new instance of the <see cref="cardSrcATV"/> component class.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        private void Initialize(uint controlJoinId, uint? itemCount)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 

            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.atvBack_PressEvent, onatvBack_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.atvPlay_PressEvent, onatvPlay_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.navReturn_PressEvent, onnavReturn_Press);
            atvDpad = new MicrosoftTeamsDemo.cardSrcATV.atvDpad(ComponentMediator, 44);
        }

        public void AddDevice(BasicTriListWithSmartObject device)
        {
            Devices.Add(device);
            ComponentMediator.HookSmartObjectEvents(device.SmartObjects[ControlJoinId]);

            ((MicrosoftTeamsDemo.cardSrcATV.atvDpad)atvDpad).AddDevice(device);
        }

        public void RemoveDevice(BasicTriListWithSmartObject device)
        {
            Devices.Remove(device);
            ComponentMediator.UnHookSmartObjectEvents(device.SmartObjects[ControlJoinId]);

            ((MicrosoftTeamsDemo.cardSrcATV.atvDpad)atvDpad).RemoveDevice(device);
        }

        #endregion

        #region CH5 Contract

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> atvBack_PressEvent;
        private void onatvBack_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = atvBack_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> atvPlay_PressEvent;
        private void onatvPlay_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = atvPlay_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> navReturn_PressEvent;
        private void onnavReturn_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = navReturn_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public void atvBack_Selected(cardSrcATVBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.atvBack_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void atvBack_Selected(bool digital)
        {
            atvBack_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void atvPlay_Selected(cardSrcATVBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.atvPlay_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void atvPlay_Selected(bool digital)
        {
            atvPlay_Selected((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void navReturn_Selected(cardSrcATVBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.navReturn_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void navReturn_Selected(bool digital)
        {
            navReturn_Selected((sig, component) => sig.BoolValue = digital);
        }


        /// <inheritdoc/>
        public void atvBack_IconURL(cardSrcATVStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.atvBack_IconURLState], this);
            }
        }

        /// <inheritdoc/>
        public void atvBack_IconURL(string serial)
        {
            atvBack_IconURL((sig, component) => sig.StringValue = serial);
        }
        /// <inheritdoc/>
        public void atvPlay_IconURL(cardSrcATVStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.atvPlay_IconURLState], this);
            }
        }

        /// <inheritdoc/>
        public void atvPlay_IconURL(string serial)
        {
            atvPlay_IconURL((sig, component) => sig.StringValue = serial);
        }

        /// <summary>
        /// ComplexComponent atvDpad
        /// </summary>
        public MicrosoftTeamsDemo.cardSrcATV.IatvDpad atvDpad { get; private set; }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "cardSrcATV", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            atvBack_PressEvent = null;
            atvPlay_PressEvent = null;
            navReturn_PressEvent = null;
        }

        #endregion
    }
}
