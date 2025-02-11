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

namespace MicrosoftTeamsDemo.widgetSrcCameras
{

    /// <summary>
    /// widgetSrcCameras
    /// </summary>
    public partial interface IwidgetSrcCameras 
    {
        object UserObject { get; set; }

        /// <summary>
        /// ComplexComponent cameraPresetList
        /// </summary>
        MicrosoftTeamsDemo.widgetSrcCameras.IcameraPresetList cameraPresetList { get; }

        /// <summary>
        /// ComplexComponent cameraDpad
        /// </summary>
        MicrosoftTeamsDemo.widgetSrcCameras.IcameraDpad cameraDpad { get; }
    }


    /// <summary>
    /// widgetSrcCameras
    /// </summary>
    internal partial class widgetSrcCameras : IwidgetSrcCameras, IDisposable
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
        }

        #endregion

        #region Construction and Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="widgetSrcCameras"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        internal widgetSrcCameras(ComponentMediator componentMediator, uint controlJoinId, uint? itemCount)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId, itemCount);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="widgetSrcCameras"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        internal widgetSrcCameras(ComponentMediator componentMediator, uint controlJoinId) : this(componentMediator, controlJoinId, null)
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
        /// Initializes a new instance of the <see cref="widgetSrcCameras"/> component class.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        private void Initialize(uint controlJoinId, uint? itemCount)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 

            cameraPresetList = new MicrosoftTeamsDemo.widgetSrcCameras.cameraPresetList(ComponentMediator, 17);
            cameraDpad = new MicrosoftTeamsDemo.widgetSrcCameras.cameraDpad(ComponentMediator, 18);
        }

        public void AddDevice(BasicTriListWithSmartObject device)
        {
            Devices.Add(device);
            ComponentMediator.HookSmartObjectEvents(device.SmartObjects[ControlJoinId]);

            ((MicrosoftTeamsDemo.widgetSrcCameras.cameraPresetList)cameraPresetList).AddDevice(device);

            ((MicrosoftTeamsDemo.widgetSrcCameras.cameraDpad)cameraDpad).AddDevice(device);
        }

        public void RemoveDevice(BasicTriListWithSmartObject device)
        {
            Devices.Remove(device);
            ComponentMediator.UnHookSmartObjectEvents(device.SmartObjects[ControlJoinId]);

            ((MicrosoftTeamsDemo.widgetSrcCameras.cameraPresetList)cameraPresetList).RemoveDevice(device);

            ((MicrosoftTeamsDemo.widgetSrcCameras.cameraDpad)cameraDpad).RemoveDevice(device);
        }

        #endregion

        #region CH5 Contract

        /// <summary>
        /// ComplexComponent cameraPresetList
        /// </summary>
        public MicrosoftTeamsDemo.widgetSrcCameras.IcameraPresetList cameraPresetList { get; private set; }

        /// <summary>
        /// ComplexComponent cameraDpad
        /// </summary>
        public MicrosoftTeamsDemo.widgetSrcCameras.IcameraDpad cameraDpad { get; private set; }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "widgetSrcCameras", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

        }

        #endregion
    }
}
