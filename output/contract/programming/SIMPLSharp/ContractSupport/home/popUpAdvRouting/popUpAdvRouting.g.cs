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

namespace MicrosoftTeamsDemo.home.popUpAdvRouting
{

    /// <summary>
    /// popUpAdvRouting
    /// </summary>
    public partial interface IpopUpAdvRouting 
    {
        object UserObject { get; set; }

        /// <summary>
        /// Event home.popUpAdvRouting.popUpCloseBtn.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> popUpCloseBtn_PressEvent;

        /// <summary>
        /// popUpAdvRouting.Visibility Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void popUpAdvRouting_Visibility_fb(popUpAdvRoutingBoolInputSigDelegate callback);

        /// <summary>
        /// popUpAdvRouting.Visibility Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void popUpAdvRouting_Visibility_fb(bool digital);

        /// <summary>
        /// home.popUpAdvRouting.popUpCloseBtn.Selected Feedback
        /// </summary>
        /// <param name="callback">The bool delegate to update the panel.</param>
        void popUpCloseBtn_Selected(popUpAdvRoutingBoolInputSigDelegate callback);

        /// <summary>
        /// home.popUpAdvRouting.popUpCloseBtn.Selected Feedback
        /// </summary>
        /// <param name="digital">The bool to update the panel.</param>
        void popUpCloseBtn_Selected(bool digital);

        /// <summary>
        /// ComplexComponent listItem_advSrc
        /// </summary>
        MicrosoftTeamsDemo.home.popUpAdvRouting.IpopUpAdvRouteSources popUpAdvRouteSources { get; }

        /// <summary>
        /// ComplexComponent listItem_advDest2
        /// </summary>
        MicrosoftTeamsDemo.home.popUpAdvRouting.IpopUpAdvRouteDest popUpAdvRouteDest { get; }
    }

    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="boolInputSig">The <see cref="BoolInputSig"/> joinInfo data.</param>
    /// <param name="popupadvrouting">The <see cref="IpopUpAdvRouting"/> on which to apply the feedback.</param>
    public delegate void popUpAdvRoutingBoolInputSigDelegate(BoolInputSig boolInputSig, IpopUpAdvRouting popupadvrouting);

    /// <summary>
    /// popUpAdvRouting
    /// </summary>
    internal partial class popUpAdvRouting : IpopUpAdvRouting, IDisposable
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
                /// Output or Event digital joinInfo from panel to Control System: home.popUpAdvRouting.popUpCloseBtn.Press
                /// home.popUpAdvRouting.popUpCloseBtn.Press
                /// </summary>
                public const uint popUpCloseBtn_PressEvent = 2;


                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: home.popUpAdvRouting.Visibility_fb
                /// popUpAdvRouting.Visibility
                /// </summary>
                public const uint popUpAdvRouting_Visibility_fbState = 1;

                /// <summary>
                /// Input or Feedback digital joinInfo from Control System to panel: home.popUpAdvRouting.popUpCloseBtn.Selected
                /// home.popUpAdvRouting.popUpCloseBtn.Selected
                /// </summary>
                public const uint popUpCloseBtn_SelectedState = 3;

            }
        }

        #endregion

        #region Construction and Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="popUpAdvRouting"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        internal popUpAdvRouting(ComponentMediator componentMediator, uint controlJoinId, uint? itemCount)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId, itemCount);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="popUpAdvRouting"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        internal popUpAdvRouting(ComponentMediator componentMediator, uint controlJoinId) : this(componentMediator, controlJoinId, null)
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
        /// Initializes a new instance of the <see cref="popUpAdvRouting"/> component class.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        private void Initialize(uint controlJoinId, uint? itemCount)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 

            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.popUpCloseBtn_PressEvent, onpopUpCloseBtn_Press);
            popUpAdvRouteSources = new MicrosoftTeamsDemo.home.popUpAdvRouting.popUpAdvRouteSources(ComponentMediator, 14);
            popUpAdvRouteDest = new MicrosoftTeamsDemo.home.popUpAdvRouting.popUpAdvRouteDest(ComponentMediator, 15);
        }

        public void AddDevice(BasicTriListWithSmartObject device)
        {
            Devices.Add(device);
            ComponentMediator.HookSmartObjectEvents(device.SmartObjects[ControlJoinId]);

            ((MicrosoftTeamsDemo.home.popUpAdvRouting.popUpAdvRouteSources)popUpAdvRouteSources).AddDevice(device);

            ((MicrosoftTeamsDemo.home.popUpAdvRouting.popUpAdvRouteDest)popUpAdvRouteDest).AddDevice(device);
        }

        public void RemoveDevice(BasicTriListWithSmartObject device)
        {
            Devices.Remove(device);
            ComponentMediator.UnHookSmartObjectEvents(device.SmartObjects[ControlJoinId]);

            ((MicrosoftTeamsDemo.home.popUpAdvRouting.popUpAdvRouteSources)popUpAdvRouteSources).RemoveDevice(device);

            ((MicrosoftTeamsDemo.home.popUpAdvRouting.popUpAdvRouteDest)popUpAdvRouteDest).RemoveDevice(device);
        }

        #endregion

        #region CH5 Contract

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> popUpCloseBtn_PressEvent;
        private void onpopUpCloseBtn_Press(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = popUpCloseBtn_PressEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public void popUpAdvRouting_Visibility_fb(popUpAdvRoutingBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.popUpAdvRouting_Visibility_fbState], this);
            }
        }

        /// <inheritdoc/>
        public void popUpAdvRouting_Visibility_fb(bool digital)
        {
            popUpAdvRouting_Visibility_fb((sig, component) => sig.BoolValue = digital);
        }
        /// <inheritdoc/>
        public void popUpCloseBtn_Selected(popUpAdvRoutingBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.popUpCloseBtn_SelectedState], this);
            }
        }

        /// <inheritdoc/>
        public void popUpCloseBtn_Selected(bool digital)
        {
            popUpCloseBtn_Selected((sig, component) => sig.BoolValue = digital);
        }

        /// <summary>
        /// ComplexComponent popUpAdvRouteSources
        /// </summary>
        public MicrosoftTeamsDemo.home.popUpAdvRouting.IpopUpAdvRouteSources popUpAdvRouteSources { get; private set; }

        /// <summary>
        /// ComplexComponent popUpAdvRouteDest
        /// </summary>
        public MicrosoftTeamsDemo.home.popUpAdvRouting.IpopUpAdvRouteDest popUpAdvRouteDest { get; private set; }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "popUpAdvRouting", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            popUpCloseBtn_PressEvent = null;
        }

        #endregion
    }
}
