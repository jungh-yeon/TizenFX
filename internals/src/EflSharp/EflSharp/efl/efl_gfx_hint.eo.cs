#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Gfx {

public partial class Constants
{
    public static readonly double HintExpand = 1.000000;
}
}

}

namespace Efl {

namespace Gfx {

/// <summary>Efl graphics hint interface
/// (Since EFL 1.22)</summary>
[Efl.Gfx.IHintConcrete.NativeMethods]
public interface IHint : 
    Efl.Eo.IWrapper, IDisposable
{
    /// <summary>Defines the aspect ratio to respect when scaling this object.
/// The aspect ratio is defined as the width / height ratio of the object. Depending on the object and its container, this hint may or may not be fully respected.
/// 
/// If any of the given aspect ratio terms are 0, the object&apos;s container will ignore the aspect and scale this object to occupy the whole available area, for any given policy.
/// (Since EFL 1.22)</summary>
/// <param name="mode">Mode of interpretation.</param>
/// <param name="sz">Base size to use for aspecting.</param>
void GetHintAspect(out Efl.Gfx.HintAspect mode, out Eina.Size2D sz);
    /// <summary>Defines the aspect ratio to respect when scaling this object.
/// The aspect ratio is defined as the width / height ratio of the object. Depending on the object and its container, this hint may or may not be fully respected.
/// 
/// If any of the given aspect ratio terms are 0, the object&apos;s container will ignore the aspect and scale this object to occupy the whole available area, for any given policy.
/// (Since EFL 1.22)</summary>
/// <param name="mode">Mode of interpretation.</param>
/// <param name="sz">Base size to use for aspecting.</param>
void SetHintAspect(Efl.Gfx.HintAspect mode, Eina.Size2D sz);
    /// <summary>Hints on the object&apos;s maximum size.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// The object container is in charge of fetching this property and placing the object accordingly.
/// 
/// Values -1 will be treated as unset hint components, when queried by managers.
/// 
/// Note: Smart objects (such as elementary) can have their own hint policy. So calling this API may or may not affect the size of smart objects.
/// (Since EFL 1.22)</summary>
/// <returns>Maximum size (hint) in pixels, (-1, -1) by default for canvas objects).</returns>
Eina.Size2D GetHintSizeMax();
    /// <summary>Hints on the object&apos;s maximum size.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// The object container is in charge of fetching this property and placing the object accordingly.
/// 
/// Values -1 will be treated as unset hint components, when queried by managers.
/// 
/// Note: Smart objects (such as elementary) can have their own hint policy. So calling this API may or may not affect the size of smart objects.
/// (Since EFL 1.22)</summary>
/// <param name="sz">Maximum size (hint) in pixels, (-1, -1) by default for canvas objects).</param>
void SetHintSizeMax(Eina.Size2D sz);
    /// <summary>Hints on the object&apos;s minimum size.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate. The object container is in charge of fetching this property and placing the object accordingly.
/// 
/// Value 0 will be treated as unset hint components, when queried by managers.
/// 
/// Note: This property is meant to be set by applications and not by EFL itself. Use this to request a specific size (treated as minimum size).
/// (Since EFL 1.22)</summary>
/// <returns>Minimum size (hint) in pixels.</returns>
Eina.Size2D GetHintSizeMin();
    /// <summary>Hints on the object&apos;s minimum size.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate. The object container is in charge of fetching this property and placing the object accordingly.
/// 
/// Value 0 will be treated as unset hint components, when queried by managers.
/// 
/// Note: This property is meant to be set by applications and not by EFL itself. Use this to request a specific size (treated as minimum size).
/// (Since EFL 1.22)</summary>
/// <param name="sz">Minimum size (hint) in pixels.</param>
void SetHintSizeMin(Eina.Size2D sz);
    /// <summary>Get the &quot;intrinsic&quot; minimum size of this object.
/// (Since EFL 1.22)</summary>
/// <returns>Minimum size (hint) in pixels.</returns>
Eina.Size2D GetHintSizeRestrictedMin();
    /// <summary>This function is protected as it is meant for widgets to indicate their &quot;intrinsic&quot; minimum size.
/// (Since EFL 1.22)</summary>
/// <param name="sz">Minimum size (hint) in pixels.</param>
void SetHintSizeRestrictedMin(Eina.Size2D sz);
    /// <summary>Read-only minimum size combining both <see cref="Efl.Gfx.IHint.HintSizeRestrictedMin"/> and <see cref="Efl.Gfx.IHint.HintSizeMin"/> hints.
/// <see cref="Efl.Gfx.IHint.HintSizeRestrictedMin"/> is intended for mostly internal usage and widget developers, and <see cref="Efl.Gfx.IHint.HintSizeMin"/> is intended to be set from application side. <see cref="Efl.Gfx.IHint.GetHintSizeCombinedMin"/> combines both values by taking their repective maximum (in both width and height), and is used internally to get an object&apos;s minimum size.
/// (Since EFL 1.22)</summary>
/// <returns>Minimum size (hint) in pixels.</returns>
Eina.Size2D GetHintSizeCombinedMin();
    /// <summary>Hints for an object&apos;s margin or padding space.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// The object container is in charge of fetching this property and placing the object accordingly.
/// 
/// Note: Smart objects (such as elementary) can have their own hint policy. So calling this API may or may not affect the size of smart objects.
/// (Since EFL 1.22)</summary>
/// <param name="l">Integer to specify left padding.</param>
/// <param name="r">Integer to specify right padding.</param>
/// <param name="t">Integer to specify top padding.</param>
/// <param name="b">Integer to specify bottom padding.</param>
void GetHintMargin(out int l, out int r, out int t, out int b);
    /// <summary>Hints for an object&apos;s margin or padding space.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// The object container is in charge of fetching this property and placing the object accordingly.
/// 
/// Note: Smart objects (such as elementary) can have their own hint policy. So calling this API may or may not affect the size of smart objects.
/// (Since EFL 1.22)</summary>
/// <param name="l">Integer to specify left padding.</param>
/// <param name="r">Integer to specify right padding.</param>
/// <param name="t">Integer to specify top padding.</param>
/// <param name="b">Integer to specify bottom padding.</param>
void SetHintMargin(int l, int r, int t, int b);
    /// <summary>Hints for an object&apos;s weight.
/// This is a hint on how a container object should resize a given child within its area. Containers may adhere to the simpler logic of just expanding the child object&apos;s dimensions to fit its own (see the <see cref="Efl.Gfx.Constants.HintExpand"/> helper weight macro) or the complete one of taking each child&apos;s weight hint as real weights to how much of its size to allocate for them in each axis. A container is supposed to, after normalizing the weights of its children (with weight  hints), distribut the space it has to layout them by those factors -- most weighted children get larger in this process than the least ones.
/// 
/// Accepted values are zero or positive values. Some containers might use this hint as a boolean, but some others might consider it as a proportion, see documentation of each container.
/// 
/// Note: Default weight hint values are 0.0, for both axis.
/// (Since EFL 1.22)</summary>
/// <param name="x">Non-negative double value to use as horizontal weight hint.</param>
/// <param name="y">Non-negative double value to use as vertical weight hint.</param>
void GetHintWeight(out double x, out double y);
    /// <summary>Hints for an object&apos;s weight.
/// This is a hint on how a container object should resize a given child within its area. Containers may adhere to the simpler logic of just expanding the child object&apos;s dimensions to fit its own (see the <see cref="Efl.Gfx.Constants.HintExpand"/> helper weight macro) or the complete one of taking each child&apos;s weight hint as real weights to how much of its size to allocate for them in each axis. A container is supposed to, after normalizing the weights of its children (with weight  hints), distribut the space it has to layout them by those factors -- most weighted children get larger in this process than the least ones.
/// 
/// Accepted values are zero or positive values. Some containers might use this hint as a boolean, but some others might consider it as a proportion, see documentation of each container.
/// 
/// Note: Default weight hint values are 0.0, for both axis.
/// (Since EFL 1.22)</summary>
/// <param name="x">Non-negative double value to use as horizontal weight hint.</param>
/// <param name="y">Non-negative double value to use as vertical weight hint.</param>
void SetHintWeight(double x, double y);
    /// <summary>Hints for an object&apos;s alignment.
/// These are hints on how to align an object inside the boundaries of a container/manager. Accepted values are in the 0.0 to 1.0 range.
/// 
/// For the horizontal component, 0.0 means to the left, 1.0 means to the right. Analogously, for the vertical component, 0.0 to the top, 1.0 means to the bottom.
/// 
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// Note: Default alignment hint values are 0.5, for both axes.
/// (Since EFL 1.22)</summary>
/// <param name="x">Double, ranging from 0.0 to 1.0.</param>
/// <param name="y">Double, ranging from 0.0 to 1.0.</param>
void GetHintAlign(out double x, out double y);
    /// <summary>Hints for an object&apos;s alignment.
/// These are hints on how to align an object inside the boundaries of a container/manager. Accepted values are in the 0.0 to 1.0 range.
/// 
/// For the horizontal component, 0.0 means to the left, 1.0 means to the right. Analogously, for the vertical component, 0.0 to the top, 1.0 means to the bottom.
/// 
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// Note: Default alignment hint values are 0.5, for both axes.
/// (Since EFL 1.22)</summary>
/// <param name="x">Double, ranging from 0.0 to 1.0.</param>
/// <param name="y">Double, ranging from 0.0 to 1.0.</param>
void SetHintAlign(double x, double y);
    /// <summary>Hints for an object&apos;s fill property that used to specify &quot;justify&quot; or &quot;fill&quot; by some users. <see cref="Efl.Gfx.IHint.GetHintFill"/> specify whether to fill the space inside the boundaries of a container/manager.
/// Maximum hints should be enforced with higher priority, if they are set. Also, any <see cref="Efl.Gfx.IHint.GetHintMargin"/> set on objects should add up to the object space on the final scene composition.
/// 
/// See documentation of possible users: in Evas, they are the <see cref="Efl.Ui.Box"/> &quot;box&quot; and <see cref="Efl.Ui.Table"/> &quot;table&quot; smart objects.
/// 
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// Note: Default fill hint values are true, for both axes.
/// (Since EFL 1.22)</summary>
/// <param name="x"><c>true</c> if to fill the object space, <c>false</c> otherwise, to use as horizontal fill hint.</param>
/// <param name="y"><c>true</c> if to fill the object space, <c>false</c> otherwise, to use as vertical fill hint.</param>
void GetHintFill(out bool x, out bool y);
    /// <summary>Hints for an object&apos;s fill property that used to specify &quot;justify&quot; or &quot;fill&quot; by some users. <see cref="Efl.Gfx.IHint.GetHintFill"/> specify whether to fill the space inside the boundaries of a container/manager.
/// Maximum hints should be enforced with higher priority, if they are set. Also, any <see cref="Efl.Gfx.IHint.GetHintMargin"/> set on objects should add up to the object space on the final scene composition.
/// 
/// See documentation of possible users: in Evas, they are the <see cref="Efl.Ui.Box"/> &quot;box&quot; and <see cref="Efl.Ui.Table"/> &quot;table&quot; smart objects.
/// 
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// Note: Default fill hint values are true, for both axes.
/// (Since EFL 1.22)</summary>
/// <param name="x"><c>true</c> if to fill the object space, <c>false</c> otherwise, to use as horizontal fill hint.</param>
/// <param name="y"><c>true</c> if to fill the object space, <c>false</c> otherwise, to use as vertical fill hint.</param>
void SetHintFill(bool x, bool y);
                                                                        /// <summary>Object hints changed.
    /// (Since EFL 1.22)</summary>
    event EventHandler HintsChangedEvt;
    /// <summary>Hints on the object&apos;s maximum size.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// The object container is in charge of fetching this property and placing the object accordingly.
/// 
/// Values -1 will be treated as unset hint components, when queried by managers.
/// 
/// Note: Smart objects (such as elementary) can have their own hint policy. So calling this API may or may not affect the size of smart objects.
/// (Since EFL 1.22)</summary>
/// <value>Maximum size (hint) in pixels, (-1, -1) by default for canvas objects).</value>
    Eina.Size2D HintSizeMax {
        get ;
        set ;
    }
    /// <summary>Hints on the object&apos;s minimum size.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate. The object container is in charge of fetching this property and placing the object accordingly.
/// 
/// Value 0 will be treated as unset hint components, when queried by managers.
/// 
/// Note: This property is meant to be set by applications and not by EFL itself. Use this to request a specific size (treated as minimum size).
/// (Since EFL 1.22)</summary>
/// <value>Minimum size (hint) in pixels.</value>
    Eina.Size2D HintSizeMin {
        get ;
        set ;
    }
    /// <summary>Internal hints for an object&apos;s minimum size.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// Values 0 will be treated as unset hint components, when queried by managers.
/// 
/// Note: This property is internal and meant for widget developers to define the absolute minimum size of the object. EFL itself sets this size internally, so any change to it from an application might be ignored. Use <see cref="Efl.Gfx.IHint.HintSizeMin"/> instead.
/// (Since EFL 1.22)</summary>
/// <value>Minimum size (hint) in pixels.</value>
    Eina.Size2D HintSizeRestrictedMin {
        get ;
        set ;
    }
    /// <summary>Read-only minimum size combining both <see cref="Efl.Gfx.IHint.HintSizeRestrictedMin"/> and <see cref="Efl.Gfx.IHint.HintSizeMin"/> hints.
/// <see cref="Efl.Gfx.IHint.HintSizeRestrictedMin"/> is intended for mostly internal usage and widget developers, and <see cref="Efl.Gfx.IHint.HintSizeMin"/> is intended to be set from application side. <see cref="Efl.Gfx.IHint.GetHintSizeCombinedMin"/> combines both values by taking their repective maximum (in both width and height), and is used internally to get an object&apos;s minimum size.
/// (Since EFL 1.22)</summary>
/// <value>Minimum size (hint) in pixels.</value>
    Eina.Size2D HintSizeCombinedMin {
        get ;
    }
}
/// <summary>Efl graphics hint interface
/// (Since EFL 1.22)</summary>
sealed public class IHintConcrete : 

IHint
    
{
    ///<summary>Pointer to the native class description.</summary>
    public System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(IHintConcrete))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    private Dictionary<(IntPtr desc, object evtDelegate), (IntPtr evtCallerPtr, Efl.EventCb evtCaller)> eoEvents = new Dictionary<(IntPtr desc, object evtDelegate), (IntPtr evtCallerPtr, Efl.EventCb evtCaller)>();
    private readonly object eventLock = new object();
    private  System.IntPtr handle;
    ///<summary>Pointer to the native instance.</summary>
    public System.IntPtr NativeHandle
    {
        get { return handle; }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Efl)] internal static extern System.IntPtr
        efl_gfx_hint_interface_get();
    /// <summary>Initializes a new instance of the <see cref="IHint"/> class.
    /// Internal usage: This is used when interacting with C code and should not be used directly.</summary>
    private IHintConcrete(System.IntPtr raw)
    {
        handle = raw;
    }
    ///<summary>Destructor.</summary>
    ~IHintConcrete()
    {
        Dispose(false);
    }

    ///<summary>Releases the underlying native instance.</summary>
    private void Dispose(bool disposing)
    {
        if (handle != System.IntPtr.Zero)
        {
            IntPtr h = handle;
            handle = IntPtr.Zero;

            IntPtr gcHandlePtr = IntPtr.Zero;
            if (eoEvents.Count != 0)
            {
                GCHandle gcHandle = GCHandle.Alloc(eoEvents);
                gcHandlePtr = GCHandle.ToIntPtr(gcHandle);
            }

            if (disposing)
            {
                Efl.Eo.Globals.efl_mono_native_dispose(h, gcHandlePtr);
            }
            else
            {
                Monitor.Enter(Efl.All.InitLock);
                if (Efl.All.MainLoopInitialized)
                {
                    Efl.Eo.Globals.efl_mono_thread_safe_native_dispose(h, gcHandlePtr);
                }

                Monitor.Exit(Efl.All.InitLock);
            }
        }

    }

    ///<summary>Releases the underlying native instance.</summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>Verifies if the given object is equal to this one.</summary>
    /// <param name="instance">The object to compare to.</param>
    /// <returns>True if both objects point to the same native object.</returns>
    public override bool Equals(object instance)
    {
        var other = instance as Efl.Object;
        if (other == null)
        {
            return false;
        }
        return this.NativeHandle == other.NativeHandle;
    }

    /// <summary>Gets the hash code for this object based on the native pointer it points to.</summary>
    /// <returns>The value of the pointer, to be used as the hash code of this object.</returns>
    public override int GetHashCode()
    {
        return this.NativeHandle.ToInt32();
    }

    /// <summary>Turns the native pointer into a string representation.</summary>
    /// <returns>A string with the type and the native pointer for this object.</returns>
    public override String ToString()
    {
        return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
    }

    ///<summary>Adds a new event handler, registering it to the native event. For internal use only.</summary>
    ///<param name="lib">The name of the native library definining the event.</param>
    ///<param name="key">The name of the native event.</param>
    ///<param name="evtCaller">Delegate to be called by native code on event raising.</param>
    ///<param name="evtDelegate">Managed delegate that will be called by evtCaller on event raising.</param>
    private void AddNativeEventHandler(string lib, string key, Efl.EventCb evtCaller, object evtDelegate)
    {
        IntPtr desc = Efl.EventDescription.GetNative(lib, key);
        if (desc == IntPtr.Zero)
        {
            Eina.Log.Error($"Failed to get native event {key}");
        }

        if (eoEvents.ContainsKey((desc, evtDelegate)))
        {
            Eina.Log.Warning($"Event proxy for event {key} already registered!");
            return;
        }

        IntPtr evtCallerPtr = Marshal.GetFunctionPointerForDelegate(evtCaller);
        if (!Efl.Eo.Globals.efl_event_callback_priority_add(handle, desc, 0, evtCallerPtr, IntPtr.Zero))
        {
            Eina.Log.Error($"Failed to add event proxy for event {key}");
            return;
        }

        eoEvents[(desc, evtDelegate)] = (evtCallerPtr, evtCaller);
        Eina.Error.RaiseIfUnhandledException();
    }

    ///<summary>Removes the given event handler for the given event. For internal use only.</summary>
    ///<param name="lib">The name of the native library definining the event.</param>
    ///<param name="key">The name of the native event.</param>
    ///<param name="evtDelegate">The delegate to be removed.</param>
    private void RemoveNativeEventHandler(string lib, string key, object evtDelegate)
    {
        IntPtr desc = Efl.EventDescription.GetNative(lib, key);
        if (desc == IntPtr.Zero)
        {
            Eina.Log.Error($"Failed to get native event {key}");
            return;
        }

        var evtPair = (desc, evtDelegate);
        if (eoEvents.TryGetValue(evtPair, out var caller))
        {
            if (!Efl.Eo.Globals.efl_event_callback_del(handle, desc, caller.evtCallerPtr, IntPtr.Zero))
            {
                Eina.Log.Error($"Failed to remove event proxy for event {key}");
                return;
            }

            eoEvents.Remove(evtPair);
            Eina.Error.RaiseIfUnhandledException();
        }
        else
        {
            Eina.Log.Error($"Trying to remove proxy for event {key} when it is nothing registered.");
        }
    }

    /// <summary>Object hints changed.
    /// (Since EFL 1.22)</summary>
    public event EventHandler HintsChangedEvt
    {
        add
        {
            lock (eventLock)
            {
                var wRef = new WeakReference(this);
                Efl.EventCb callerCb = (IntPtr data, ref Efl.Event.NativeStruct evt) =>
                {
                    var obj = wRef.Target as Efl.Eo.IWrapper;
                    if (obj != null)
                    {
                        EventArgs args = EventArgs.Empty;
                        try
                        {
                            value?.Invoke(obj, args);
                        }
                        catch (Exception e)
                        {
                            Eina.Log.Error(e.ToString());
                            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                        }
                    }
                };

                string key = "_EFL_GFX_ENTITY_EVENT_HINTS_CHANGED";
                AddNativeEventHandler(efl.Libs.Efl, key, callerCb, value);
            }
        }

        remove
        {
            lock (eventLock)
            {
                string key = "_EFL_GFX_ENTITY_EVENT_HINTS_CHANGED";
                RemoveNativeEventHandler(efl.Libs.Efl, key, value);
            }
        }
    }
    ///<summary>Method to raise event HintsChangedEvt.</summary>
    public void OnHintsChangedEvt(EventArgs e)
    {
        var key = "_EFL_GFX_ENTITY_EVENT_HINTS_CHANGED";
        IntPtr desc = Efl.EventDescription.GetNative(efl.Libs.Efl, key);
        if (desc == IntPtr.Zero)
        {
            Eina.Log.Error($"Failed to get native event {key}");
            return;
        }

        Efl.Eo.Globals.efl_event_callback_call(this.NativeHandle, desc, IntPtr.Zero);
    }
    /// <summary>Defines the aspect ratio to respect when scaling this object.
    /// The aspect ratio is defined as the width / height ratio of the object. Depending on the object and its container, this hint may or may not be fully respected.
    /// 
    /// If any of the given aspect ratio terms are 0, the object&apos;s container will ignore the aspect and scale this object to occupy the whole available area, for any given policy.
    /// (Since EFL 1.22)</summary>
    /// <param name="mode">Mode of interpretation.</param>
    /// <param name="sz">Base size to use for aspecting.</param>
    public void GetHintAspect(out Efl.Gfx.HintAspect mode, out Eina.Size2D sz) {
                                 var _out_sz = new Eina.Size2D.NativeStruct();
                        Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_aspect_get_ptr.Value.Delegate(this.NativeHandle,out mode, out _out_sz);
        Eina.Error.RaiseIfUnhandledException();
                sz = _out_sz;
                         }
    /// <summary>Defines the aspect ratio to respect when scaling this object.
    /// The aspect ratio is defined as the width / height ratio of the object. Depending on the object and its container, this hint may or may not be fully respected.
    /// 
    /// If any of the given aspect ratio terms are 0, the object&apos;s container will ignore the aspect and scale this object to occupy the whole available area, for any given policy.
    /// (Since EFL 1.22)</summary>
    /// <param name="mode">Mode of interpretation.</param>
    /// <param name="sz">Base size to use for aspecting.</param>
    public void SetHintAspect(Efl.Gfx.HintAspect mode, Eina.Size2D sz) {
                 Eina.Size2D.NativeStruct _in_sz = sz;
                                        Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_aspect_set_ptr.Value.Delegate(this.NativeHandle,mode, _in_sz);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Hints on the object&apos;s maximum size.
    /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
    /// 
    /// The object container is in charge of fetching this property and placing the object accordingly.
    /// 
    /// Values -1 will be treated as unset hint components, when queried by managers.
    /// 
    /// Note: Smart objects (such as elementary) can have their own hint policy. So calling this API may or may not affect the size of smart objects.
    /// (Since EFL 1.22)</summary>
    /// <returns>Maximum size (hint) in pixels, (-1, -1) by default for canvas objects).</returns>
    public Eina.Size2D GetHintSizeMax() {
         var _ret_var = Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_size_max_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Hints on the object&apos;s maximum size.
    /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
    /// 
    /// The object container is in charge of fetching this property and placing the object accordingly.
    /// 
    /// Values -1 will be treated as unset hint components, when queried by managers.
    /// 
    /// Note: Smart objects (such as elementary) can have their own hint policy. So calling this API may or may not affect the size of smart objects.
    /// (Since EFL 1.22)</summary>
    /// <param name="sz">Maximum size (hint) in pixels, (-1, -1) by default for canvas objects).</param>
    public void SetHintSizeMax(Eina.Size2D sz) {
         Eina.Size2D.NativeStruct _in_sz = sz;
                        Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_size_max_set_ptr.Value.Delegate(this.NativeHandle,_in_sz);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Hints on the object&apos;s minimum size.
    /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate. The object container is in charge of fetching this property and placing the object accordingly.
    /// 
    /// Value 0 will be treated as unset hint components, when queried by managers.
    /// 
    /// Note: This property is meant to be set by applications and not by EFL itself. Use this to request a specific size (treated as minimum size).
    /// (Since EFL 1.22)</summary>
    /// <returns>Minimum size (hint) in pixels.</returns>
    public Eina.Size2D GetHintSizeMin() {
         var _ret_var = Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_size_min_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Hints on the object&apos;s minimum size.
    /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate. The object container is in charge of fetching this property and placing the object accordingly.
    /// 
    /// Value 0 will be treated as unset hint components, when queried by managers.
    /// 
    /// Note: This property is meant to be set by applications and not by EFL itself. Use this to request a specific size (treated as minimum size).
    /// (Since EFL 1.22)</summary>
    /// <param name="sz">Minimum size (hint) in pixels.</param>
    public void SetHintSizeMin(Eina.Size2D sz) {
         Eina.Size2D.NativeStruct _in_sz = sz;
                        Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_size_min_set_ptr.Value.Delegate(this.NativeHandle,_in_sz);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Get the &quot;intrinsic&quot; minimum size of this object.
    /// (Since EFL 1.22)</summary>
    /// <returns>Minimum size (hint) in pixels.</returns>
    public Eina.Size2D GetHintSizeRestrictedMin() {
         var _ret_var = Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_size_restricted_min_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>This function is protected as it is meant for widgets to indicate their &quot;intrinsic&quot; minimum size.
    /// (Since EFL 1.22)</summary>
    /// <param name="sz">Minimum size (hint) in pixels.</param>
    public void SetHintSizeRestrictedMin(Eina.Size2D sz) {
         Eina.Size2D.NativeStruct _in_sz = sz;
                        Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_size_restricted_min_set_ptr.Value.Delegate(this.NativeHandle,_in_sz);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Read-only minimum size combining both <see cref="Efl.Gfx.IHint.HintSizeRestrictedMin"/> and <see cref="Efl.Gfx.IHint.HintSizeMin"/> hints.
    /// <see cref="Efl.Gfx.IHint.HintSizeRestrictedMin"/> is intended for mostly internal usage and widget developers, and <see cref="Efl.Gfx.IHint.HintSizeMin"/> is intended to be set from application side. <see cref="Efl.Gfx.IHint.GetHintSizeCombinedMin"/> combines both values by taking their repective maximum (in both width and height), and is used internally to get an object&apos;s minimum size.
    /// (Since EFL 1.22)</summary>
    /// <returns>Minimum size (hint) in pixels.</returns>
    public Eina.Size2D GetHintSizeCombinedMin() {
         var _ret_var = Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_size_combined_min_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Hints for an object&apos;s margin or padding space.
    /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
    /// 
    /// The object container is in charge of fetching this property and placing the object accordingly.
    /// 
    /// Note: Smart objects (such as elementary) can have their own hint policy. So calling this API may or may not affect the size of smart objects.
    /// (Since EFL 1.22)</summary>
    /// <param name="l">Integer to specify left padding.</param>
    /// <param name="r">Integer to specify right padding.</param>
    /// <param name="t">Integer to specify top padding.</param>
    /// <param name="b">Integer to specify bottom padding.</param>
    public void GetHintMargin(out int l, out int r, out int t, out int b) {
                                                                                                         Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_margin_get_ptr.Value.Delegate(this.NativeHandle,out l, out r, out t, out b);
        Eina.Error.RaiseIfUnhandledException();
                                                                         }
    /// <summary>Hints for an object&apos;s margin or padding space.
    /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
    /// 
    /// The object container is in charge of fetching this property and placing the object accordingly.
    /// 
    /// Note: Smart objects (such as elementary) can have their own hint policy. So calling this API may or may not affect the size of smart objects.
    /// (Since EFL 1.22)</summary>
    /// <param name="l">Integer to specify left padding.</param>
    /// <param name="r">Integer to specify right padding.</param>
    /// <param name="t">Integer to specify top padding.</param>
    /// <param name="b">Integer to specify bottom padding.</param>
    public void SetHintMargin(int l, int r, int t, int b) {
                                                                                                         Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_margin_set_ptr.Value.Delegate(this.NativeHandle,l, r, t, b);
        Eina.Error.RaiseIfUnhandledException();
                                                                         }
    /// <summary>Hints for an object&apos;s weight.
    /// This is a hint on how a container object should resize a given child within its area. Containers may adhere to the simpler logic of just expanding the child object&apos;s dimensions to fit its own (see the <see cref="Efl.Gfx.Constants.HintExpand"/> helper weight macro) or the complete one of taking each child&apos;s weight hint as real weights to how much of its size to allocate for them in each axis. A container is supposed to, after normalizing the weights of its children (with weight  hints), distribut the space it has to layout them by those factors -- most weighted children get larger in this process than the least ones.
    /// 
    /// Accepted values are zero or positive values. Some containers might use this hint as a boolean, but some others might consider it as a proportion, see documentation of each container.
    /// 
    /// Note: Default weight hint values are 0.0, for both axis.
    /// (Since EFL 1.22)</summary>
    /// <param name="x">Non-negative double value to use as horizontal weight hint.</param>
    /// <param name="y">Non-negative double value to use as vertical weight hint.</param>
    public void GetHintWeight(out double x, out double y) {
                                                         Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_weight_get_ptr.Value.Delegate(this.NativeHandle,out x, out y);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Hints for an object&apos;s weight.
    /// This is a hint on how a container object should resize a given child within its area. Containers may adhere to the simpler logic of just expanding the child object&apos;s dimensions to fit its own (see the <see cref="Efl.Gfx.Constants.HintExpand"/> helper weight macro) or the complete one of taking each child&apos;s weight hint as real weights to how much of its size to allocate for them in each axis. A container is supposed to, after normalizing the weights of its children (with weight  hints), distribut the space it has to layout them by those factors -- most weighted children get larger in this process than the least ones.
    /// 
    /// Accepted values are zero or positive values. Some containers might use this hint as a boolean, but some others might consider it as a proportion, see documentation of each container.
    /// 
    /// Note: Default weight hint values are 0.0, for both axis.
    /// (Since EFL 1.22)</summary>
    /// <param name="x">Non-negative double value to use as horizontal weight hint.</param>
    /// <param name="y">Non-negative double value to use as vertical weight hint.</param>
    public void SetHintWeight(double x, double y) {
                                                         Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_weight_set_ptr.Value.Delegate(this.NativeHandle,x, y);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Hints for an object&apos;s alignment.
    /// These are hints on how to align an object inside the boundaries of a container/manager. Accepted values are in the 0.0 to 1.0 range.
    /// 
    /// For the horizontal component, 0.0 means to the left, 1.0 means to the right. Analogously, for the vertical component, 0.0 to the top, 1.0 means to the bottom.
    /// 
    /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
    /// 
    /// Note: Default alignment hint values are 0.5, for both axes.
    /// (Since EFL 1.22)</summary>
    /// <param name="x">Double, ranging from 0.0 to 1.0.</param>
    /// <param name="y">Double, ranging from 0.0 to 1.0.</param>
    public void GetHintAlign(out double x, out double y) {
                                                         Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_align_get_ptr.Value.Delegate(this.NativeHandle,out x, out y);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Hints for an object&apos;s alignment.
    /// These are hints on how to align an object inside the boundaries of a container/manager. Accepted values are in the 0.0 to 1.0 range.
    /// 
    /// For the horizontal component, 0.0 means to the left, 1.0 means to the right. Analogously, for the vertical component, 0.0 to the top, 1.0 means to the bottom.
    /// 
    /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
    /// 
    /// Note: Default alignment hint values are 0.5, for both axes.
    /// (Since EFL 1.22)</summary>
    /// <param name="x">Double, ranging from 0.0 to 1.0.</param>
    /// <param name="y">Double, ranging from 0.0 to 1.0.</param>
    public void SetHintAlign(double x, double y) {
                                                         Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_align_set_ptr.Value.Delegate(this.NativeHandle,x, y);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Hints for an object&apos;s fill property that used to specify &quot;justify&quot; or &quot;fill&quot; by some users. <see cref="Efl.Gfx.IHint.GetHintFill"/> specify whether to fill the space inside the boundaries of a container/manager.
    /// Maximum hints should be enforced with higher priority, if they are set. Also, any <see cref="Efl.Gfx.IHint.GetHintMargin"/> set on objects should add up to the object space on the final scene composition.
    /// 
    /// See documentation of possible users: in Evas, they are the <see cref="Efl.Ui.Box"/> &quot;box&quot; and <see cref="Efl.Ui.Table"/> &quot;table&quot; smart objects.
    /// 
    /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
    /// 
    /// Note: Default fill hint values are true, for both axes.
    /// (Since EFL 1.22)</summary>
    /// <param name="x"><c>true</c> if to fill the object space, <c>false</c> otherwise, to use as horizontal fill hint.</param>
    /// <param name="y"><c>true</c> if to fill the object space, <c>false</c> otherwise, to use as vertical fill hint.</param>
    public void GetHintFill(out bool x, out bool y) {
                                                         Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_fill_get_ptr.Value.Delegate(this.NativeHandle,out x, out y);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Hints for an object&apos;s fill property that used to specify &quot;justify&quot; or &quot;fill&quot; by some users. <see cref="Efl.Gfx.IHint.GetHintFill"/> specify whether to fill the space inside the boundaries of a container/manager.
    /// Maximum hints should be enforced with higher priority, if they are set. Also, any <see cref="Efl.Gfx.IHint.GetHintMargin"/> set on objects should add up to the object space on the final scene composition.
    /// 
    /// See documentation of possible users: in Evas, they are the <see cref="Efl.Ui.Box"/> &quot;box&quot; and <see cref="Efl.Ui.Table"/> &quot;table&quot; smart objects.
    /// 
    /// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
    /// 
    /// Note: Default fill hint values are true, for both axes.
    /// (Since EFL 1.22)</summary>
    /// <param name="x"><c>true</c> if to fill the object space, <c>false</c> otherwise, to use as horizontal fill hint.</param>
    /// <param name="y"><c>true</c> if to fill the object space, <c>false</c> otherwise, to use as vertical fill hint.</param>
    public void SetHintFill(bool x, bool y) {
                                                         Efl.Gfx.IHintConcrete.NativeMethods.efl_gfx_hint_fill_set_ptr.Value.Delegate(this.NativeHandle,x, y);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Hints on the object&apos;s maximum size.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// The object container is in charge of fetching this property and placing the object accordingly.
/// 
/// Values -1 will be treated as unset hint components, when queried by managers.
/// 
/// Note: Smart objects (such as elementary) can have their own hint policy. So calling this API may or may not affect the size of smart objects.
/// (Since EFL 1.22)</summary>
/// <value>Maximum size (hint) in pixels, (-1, -1) by default for canvas objects).</value>
    public Eina.Size2D HintSizeMax {
        get { return GetHintSizeMax(); }
        set { SetHintSizeMax(value); }
    }
    /// <summary>Hints on the object&apos;s minimum size.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate. The object container is in charge of fetching this property and placing the object accordingly.
/// 
/// Value 0 will be treated as unset hint components, when queried by managers.
/// 
/// Note: This property is meant to be set by applications and not by EFL itself. Use this to request a specific size (treated as minimum size).
/// (Since EFL 1.22)</summary>
/// <value>Minimum size (hint) in pixels.</value>
    public Eina.Size2D HintSizeMin {
        get { return GetHintSizeMin(); }
        set { SetHintSizeMin(value); }
    }
    /// <summary>Internal hints for an object&apos;s minimum size.
/// This is not a size enforcement in any way, it&apos;s just a hint that should be used whenever appropriate.
/// 
/// Values 0 will be treated as unset hint components, when queried by managers.
/// 
/// Note: This property is internal and meant for widget developers to define the absolute minimum size of the object. EFL itself sets this size internally, so any change to it from an application might be ignored. Use <see cref="Efl.Gfx.IHint.HintSizeMin"/> instead.
/// (Since EFL 1.22)</summary>
/// <value>Minimum size (hint) in pixels.</value>
    public Eina.Size2D HintSizeRestrictedMin {
        get { return GetHintSizeRestrictedMin(); }
        set { SetHintSizeRestrictedMin(value); }
    }
    /// <summary>Read-only minimum size combining both <see cref="Efl.Gfx.IHint.HintSizeRestrictedMin"/> and <see cref="Efl.Gfx.IHint.HintSizeMin"/> hints.
/// <see cref="Efl.Gfx.IHint.HintSizeRestrictedMin"/> is intended for mostly internal usage and widget developers, and <see cref="Efl.Gfx.IHint.HintSizeMin"/> is intended to be set from application side. <see cref="Efl.Gfx.IHint.GetHintSizeCombinedMin"/> combines both values by taking their repective maximum (in both width and height), and is used internally to get an object&apos;s minimum size.
/// (Since EFL 1.22)</summary>
/// <value>Minimum size (hint) in pixels.</value>
    public Eina.Size2D HintSizeCombinedMin {
        get { return GetHintSizeCombinedMin(); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Gfx.IHintConcrete.efl_gfx_hint_interface_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public class NativeMethods  : Efl.Eo.NativeClass
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Efl);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_gfx_hint_aspect_get_static_delegate == null)
            {
                efl_gfx_hint_aspect_get_static_delegate = new efl_gfx_hint_aspect_get_delegate(hint_aspect_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetHintAspect") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_aspect_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_aspect_get_static_delegate) });
            }

            if (efl_gfx_hint_aspect_set_static_delegate == null)
            {
                efl_gfx_hint_aspect_set_static_delegate = new efl_gfx_hint_aspect_set_delegate(hint_aspect_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetHintAspect") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_aspect_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_aspect_set_static_delegate) });
            }

            if (efl_gfx_hint_size_max_get_static_delegate == null)
            {
                efl_gfx_hint_size_max_get_static_delegate = new efl_gfx_hint_size_max_get_delegate(hint_size_max_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetHintSizeMax") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_size_max_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_size_max_get_static_delegate) });
            }

            if (efl_gfx_hint_size_max_set_static_delegate == null)
            {
                efl_gfx_hint_size_max_set_static_delegate = new efl_gfx_hint_size_max_set_delegate(hint_size_max_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetHintSizeMax") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_size_max_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_size_max_set_static_delegate) });
            }

            if (efl_gfx_hint_size_min_get_static_delegate == null)
            {
                efl_gfx_hint_size_min_get_static_delegate = new efl_gfx_hint_size_min_get_delegate(hint_size_min_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetHintSizeMin") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_size_min_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_size_min_get_static_delegate) });
            }

            if (efl_gfx_hint_size_min_set_static_delegate == null)
            {
                efl_gfx_hint_size_min_set_static_delegate = new efl_gfx_hint_size_min_set_delegate(hint_size_min_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetHintSizeMin") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_size_min_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_size_min_set_static_delegate) });
            }

            if (efl_gfx_hint_size_restricted_min_get_static_delegate == null)
            {
                efl_gfx_hint_size_restricted_min_get_static_delegate = new efl_gfx_hint_size_restricted_min_get_delegate(hint_size_restricted_min_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetHintSizeRestrictedMin") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_size_restricted_min_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_size_restricted_min_get_static_delegate) });
            }

            if (efl_gfx_hint_size_restricted_min_set_static_delegate == null)
            {
                efl_gfx_hint_size_restricted_min_set_static_delegate = new efl_gfx_hint_size_restricted_min_set_delegate(hint_size_restricted_min_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetHintSizeRestrictedMin") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_size_restricted_min_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_size_restricted_min_set_static_delegate) });
            }

            if (efl_gfx_hint_size_combined_min_get_static_delegate == null)
            {
                efl_gfx_hint_size_combined_min_get_static_delegate = new efl_gfx_hint_size_combined_min_get_delegate(hint_size_combined_min_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetHintSizeCombinedMin") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_size_combined_min_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_size_combined_min_get_static_delegate) });
            }

            if (efl_gfx_hint_margin_get_static_delegate == null)
            {
                efl_gfx_hint_margin_get_static_delegate = new efl_gfx_hint_margin_get_delegate(hint_margin_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetHintMargin") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_margin_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_margin_get_static_delegate) });
            }

            if (efl_gfx_hint_margin_set_static_delegate == null)
            {
                efl_gfx_hint_margin_set_static_delegate = new efl_gfx_hint_margin_set_delegate(hint_margin_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetHintMargin") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_margin_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_margin_set_static_delegate) });
            }

            if (efl_gfx_hint_weight_get_static_delegate == null)
            {
                efl_gfx_hint_weight_get_static_delegate = new efl_gfx_hint_weight_get_delegate(hint_weight_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetHintWeight") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_weight_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_weight_get_static_delegate) });
            }

            if (efl_gfx_hint_weight_set_static_delegate == null)
            {
                efl_gfx_hint_weight_set_static_delegate = new efl_gfx_hint_weight_set_delegate(hint_weight_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetHintWeight") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_weight_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_weight_set_static_delegate) });
            }

            if (efl_gfx_hint_align_get_static_delegate == null)
            {
                efl_gfx_hint_align_get_static_delegate = new efl_gfx_hint_align_get_delegate(hint_align_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetHintAlign") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_align_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_align_get_static_delegate) });
            }

            if (efl_gfx_hint_align_set_static_delegate == null)
            {
                efl_gfx_hint_align_set_static_delegate = new efl_gfx_hint_align_set_delegate(hint_align_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetHintAlign") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_align_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_align_set_static_delegate) });
            }

            if (efl_gfx_hint_fill_get_static_delegate == null)
            {
                efl_gfx_hint_fill_get_static_delegate = new efl_gfx_hint_fill_get_delegate(hint_fill_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetHintFill") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_fill_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_fill_get_static_delegate) });
            }

            if (efl_gfx_hint_fill_set_static_delegate == null)
            {
                efl_gfx_hint_fill_set_static_delegate = new efl_gfx_hint_fill_set_delegate(hint_fill_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetHintFill") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_gfx_hint_fill_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_hint_fill_set_static_delegate) });
            }

            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Gfx.IHintConcrete.efl_gfx_hint_interface_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        
        private delegate void efl_gfx_hint_aspect_get_delegate(System.IntPtr obj, System.IntPtr pd,  out Efl.Gfx.HintAspect mode,  out Eina.Size2D.NativeStruct sz);

        
        public delegate void efl_gfx_hint_aspect_get_api_delegate(System.IntPtr obj,  out Efl.Gfx.HintAspect mode,  out Eina.Size2D.NativeStruct sz);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_aspect_get_api_delegate> efl_gfx_hint_aspect_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_aspect_get_api_delegate>(Module, "efl_gfx_hint_aspect_get");

        private static void hint_aspect_get(System.IntPtr obj, System.IntPtr pd, out Efl.Gfx.HintAspect mode, out Eina.Size2D.NativeStruct sz)
        {
            Eina.Log.Debug("function efl_gfx_hint_aspect_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                        mode = default(Efl.Gfx.HintAspect);        Eina.Size2D _out_sz = default(Eina.Size2D);
                            
                try
                {
                    ((IHint)wrapper).GetHintAspect(out mode, out _out_sz);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                sz = _out_sz;
                        
            }
            else
            {
                efl_gfx_hint_aspect_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out mode, out sz);
            }
        }

        private static efl_gfx_hint_aspect_get_delegate efl_gfx_hint_aspect_get_static_delegate;

        
        private delegate void efl_gfx_hint_aspect_set_delegate(System.IntPtr obj, System.IntPtr pd,  Efl.Gfx.HintAspect mode,  Eina.Size2D.NativeStruct sz);

        
        public delegate void efl_gfx_hint_aspect_set_api_delegate(System.IntPtr obj,  Efl.Gfx.HintAspect mode,  Eina.Size2D.NativeStruct sz);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_aspect_set_api_delegate> efl_gfx_hint_aspect_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_aspect_set_api_delegate>(Module, "efl_gfx_hint_aspect_set");

        private static void hint_aspect_set(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.HintAspect mode, Eina.Size2D.NativeStruct sz)
        {
            Eina.Log.Debug("function efl_gfx_hint_aspect_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                Eina.Size2D _in_sz = sz;
                                            
                try
                {
                    ((IHint)wrapper).SetHintAspect(mode, _in_sz);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_gfx_hint_aspect_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), mode, sz);
            }
        }

        private static efl_gfx_hint_aspect_set_delegate efl_gfx_hint_aspect_set_static_delegate;

        
        private delegate Eina.Size2D.NativeStruct efl_gfx_hint_size_max_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Eina.Size2D.NativeStruct efl_gfx_hint_size_max_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_size_max_get_api_delegate> efl_gfx_hint_size_max_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_size_max_get_api_delegate>(Module, "efl_gfx_hint_size_max_get");

        private static Eina.Size2D.NativeStruct hint_size_max_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_gfx_hint_size_max_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Eina.Size2D _ret_var = default(Eina.Size2D);
                try
                {
                    _ret_var = ((IHint)wrapper).GetHintSizeMax();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_gfx_hint_size_max_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_gfx_hint_size_max_get_delegate efl_gfx_hint_size_max_get_static_delegate;

        
        private delegate void efl_gfx_hint_size_max_set_delegate(System.IntPtr obj, System.IntPtr pd,  Eina.Size2D.NativeStruct sz);

        
        public delegate void efl_gfx_hint_size_max_set_api_delegate(System.IntPtr obj,  Eina.Size2D.NativeStruct sz);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_size_max_set_api_delegate> efl_gfx_hint_size_max_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_size_max_set_api_delegate>(Module, "efl_gfx_hint_size_max_set");

        private static void hint_size_max_set(System.IntPtr obj, System.IntPtr pd, Eina.Size2D.NativeStruct sz)
        {
            Eina.Log.Debug("function efl_gfx_hint_size_max_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
        Eina.Size2D _in_sz = sz;
                            
                try
                {
                    ((IHint)wrapper).SetHintSizeMax(_in_sz);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_gfx_hint_size_max_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), sz);
            }
        }

        private static efl_gfx_hint_size_max_set_delegate efl_gfx_hint_size_max_set_static_delegate;

        
        private delegate Eina.Size2D.NativeStruct efl_gfx_hint_size_min_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Eina.Size2D.NativeStruct efl_gfx_hint_size_min_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_size_min_get_api_delegate> efl_gfx_hint_size_min_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_size_min_get_api_delegate>(Module, "efl_gfx_hint_size_min_get");

        private static Eina.Size2D.NativeStruct hint_size_min_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_gfx_hint_size_min_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Eina.Size2D _ret_var = default(Eina.Size2D);
                try
                {
                    _ret_var = ((IHint)wrapper).GetHintSizeMin();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_gfx_hint_size_min_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_gfx_hint_size_min_get_delegate efl_gfx_hint_size_min_get_static_delegate;

        
        private delegate void efl_gfx_hint_size_min_set_delegate(System.IntPtr obj, System.IntPtr pd,  Eina.Size2D.NativeStruct sz);

        
        public delegate void efl_gfx_hint_size_min_set_api_delegate(System.IntPtr obj,  Eina.Size2D.NativeStruct sz);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_size_min_set_api_delegate> efl_gfx_hint_size_min_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_size_min_set_api_delegate>(Module, "efl_gfx_hint_size_min_set");

        private static void hint_size_min_set(System.IntPtr obj, System.IntPtr pd, Eina.Size2D.NativeStruct sz)
        {
            Eina.Log.Debug("function efl_gfx_hint_size_min_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
        Eina.Size2D _in_sz = sz;
                            
                try
                {
                    ((IHint)wrapper).SetHintSizeMin(_in_sz);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_gfx_hint_size_min_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), sz);
            }
        }

        private static efl_gfx_hint_size_min_set_delegate efl_gfx_hint_size_min_set_static_delegate;

        
        private delegate Eina.Size2D.NativeStruct efl_gfx_hint_size_restricted_min_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Eina.Size2D.NativeStruct efl_gfx_hint_size_restricted_min_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_size_restricted_min_get_api_delegate> efl_gfx_hint_size_restricted_min_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_size_restricted_min_get_api_delegate>(Module, "efl_gfx_hint_size_restricted_min_get");

        private static Eina.Size2D.NativeStruct hint_size_restricted_min_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_gfx_hint_size_restricted_min_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Eina.Size2D _ret_var = default(Eina.Size2D);
                try
                {
                    _ret_var = ((IHint)wrapper).GetHintSizeRestrictedMin();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_gfx_hint_size_restricted_min_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_gfx_hint_size_restricted_min_get_delegate efl_gfx_hint_size_restricted_min_get_static_delegate;

        
        private delegate void efl_gfx_hint_size_restricted_min_set_delegate(System.IntPtr obj, System.IntPtr pd,  Eina.Size2D.NativeStruct sz);

        
        public delegate void efl_gfx_hint_size_restricted_min_set_api_delegate(System.IntPtr obj,  Eina.Size2D.NativeStruct sz);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_size_restricted_min_set_api_delegate> efl_gfx_hint_size_restricted_min_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_size_restricted_min_set_api_delegate>(Module, "efl_gfx_hint_size_restricted_min_set");

        private static void hint_size_restricted_min_set(System.IntPtr obj, System.IntPtr pd, Eina.Size2D.NativeStruct sz)
        {
            Eina.Log.Debug("function efl_gfx_hint_size_restricted_min_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
        Eina.Size2D _in_sz = sz;
                            
                try
                {
                    ((IHint)wrapper).SetHintSizeRestrictedMin(_in_sz);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_gfx_hint_size_restricted_min_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), sz);
            }
        }

        private static efl_gfx_hint_size_restricted_min_set_delegate efl_gfx_hint_size_restricted_min_set_static_delegate;

        
        private delegate Eina.Size2D.NativeStruct efl_gfx_hint_size_combined_min_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Eina.Size2D.NativeStruct efl_gfx_hint_size_combined_min_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_size_combined_min_get_api_delegate> efl_gfx_hint_size_combined_min_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_size_combined_min_get_api_delegate>(Module, "efl_gfx_hint_size_combined_min_get");

        private static Eina.Size2D.NativeStruct hint_size_combined_min_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_gfx_hint_size_combined_min_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Eina.Size2D _ret_var = default(Eina.Size2D);
                try
                {
                    _ret_var = ((IHint)wrapper).GetHintSizeCombinedMin();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_gfx_hint_size_combined_min_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_gfx_hint_size_combined_min_get_delegate efl_gfx_hint_size_combined_min_get_static_delegate;

        
        private delegate void efl_gfx_hint_margin_get_delegate(System.IntPtr obj, System.IntPtr pd,  out int l,  out int r,  out int t,  out int b);

        
        public delegate void efl_gfx_hint_margin_get_api_delegate(System.IntPtr obj,  out int l,  out int r,  out int t,  out int b);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_margin_get_api_delegate> efl_gfx_hint_margin_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_margin_get_api_delegate>(Module, "efl_gfx_hint_margin_get");

        private static void hint_margin_get(System.IntPtr obj, System.IntPtr pd, out int l, out int r, out int t, out int b)
        {
            Eina.Log.Debug("function efl_gfx_hint_margin_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                        l = default(int);        r = default(int);        t = default(int);        b = default(int);                                            
                try
                {
                    ((IHint)wrapper).GetHintMargin(out l, out r, out t, out b);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                                                        
            }
            else
            {
                efl_gfx_hint_margin_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out l, out r, out t, out b);
            }
        }

        private static efl_gfx_hint_margin_get_delegate efl_gfx_hint_margin_get_static_delegate;

        
        private delegate void efl_gfx_hint_margin_set_delegate(System.IntPtr obj, System.IntPtr pd,  int l,  int r,  int t,  int b);

        
        public delegate void efl_gfx_hint_margin_set_api_delegate(System.IntPtr obj,  int l,  int r,  int t,  int b);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_margin_set_api_delegate> efl_gfx_hint_margin_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_margin_set_api_delegate>(Module, "efl_gfx_hint_margin_set");

        private static void hint_margin_set(System.IntPtr obj, System.IntPtr pd, int l, int r, int t, int b)
        {
            Eina.Log.Debug("function efl_gfx_hint_margin_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                                                                            
                try
                {
                    ((IHint)wrapper).SetHintMargin(l, r, t, b);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                                                        
            }
            else
            {
                efl_gfx_hint_margin_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), l, r, t, b);
            }
        }

        private static efl_gfx_hint_margin_set_delegate efl_gfx_hint_margin_set_static_delegate;

        
        private delegate void efl_gfx_hint_weight_get_delegate(System.IntPtr obj, System.IntPtr pd,  out double x,  out double y);

        
        public delegate void efl_gfx_hint_weight_get_api_delegate(System.IntPtr obj,  out double x,  out double y);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_weight_get_api_delegate> efl_gfx_hint_weight_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_weight_get_api_delegate>(Module, "efl_gfx_hint_weight_get");

        private static void hint_weight_get(System.IntPtr obj, System.IntPtr pd, out double x, out double y)
        {
            Eina.Log.Debug("function efl_gfx_hint_weight_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                        x = default(double);        y = default(double);                            
                try
                {
                    ((IHint)wrapper).GetHintWeight(out x, out y);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_gfx_hint_weight_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out x, out y);
            }
        }

        private static efl_gfx_hint_weight_get_delegate efl_gfx_hint_weight_get_static_delegate;

        
        private delegate void efl_gfx_hint_weight_set_delegate(System.IntPtr obj, System.IntPtr pd,  double x,  double y);

        
        public delegate void efl_gfx_hint_weight_set_api_delegate(System.IntPtr obj,  double x,  double y);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_weight_set_api_delegate> efl_gfx_hint_weight_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_weight_set_api_delegate>(Module, "efl_gfx_hint_weight_set");

        private static void hint_weight_set(System.IntPtr obj, System.IntPtr pd, double x, double y)
        {
            Eina.Log.Debug("function efl_gfx_hint_weight_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                            
                try
                {
                    ((IHint)wrapper).SetHintWeight(x, y);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_gfx_hint_weight_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), x, y);
            }
        }

        private static efl_gfx_hint_weight_set_delegate efl_gfx_hint_weight_set_static_delegate;

        
        private delegate void efl_gfx_hint_align_get_delegate(System.IntPtr obj, System.IntPtr pd,  out double x,  out double y);

        
        public delegate void efl_gfx_hint_align_get_api_delegate(System.IntPtr obj,  out double x,  out double y);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_align_get_api_delegate> efl_gfx_hint_align_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_align_get_api_delegate>(Module, "efl_gfx_hint_align_get");

        private static void hint_align_get(System.IntPtr obj, System.IntPtr pd, out double x, out double y)
        {
            Eina.Log.Debug("function efl_gfx_hint_align_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                        x = default(double);        y = default(double);                            
                try
                {
                    ((IHint)wrapper).GetHintAlign(out x, out y);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_gfx_hint_align_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out x, out y);
            }
        }

        private static efl_gfx_hint_align_get_delegate efl_gfx_hint_align_get_static_delegate;

        
        private delegate void efl_gfx_hint_align_set_delegate(System.IntPtr obj, System.IntPtr pd,  double x,  double y);

        
        public delegate void efl_gfx_hint_align_set_api_delegate(System.IntPtr obj,  double x,  double y);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_align_set_api_delegate> efl_gfx_hint_align_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_align_set_api_delegate>(Module, "efl_gfx_hint_align_set");

        private static void hint_align_set(System.IntPtr obj, System.IntPtr pd, double x, double y)
        {
            Eina.Log.Debug("function efl_gfx_hint_align_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                            
                try
                {
                    ((IHint)wrapper).SetHintAlign(x, y);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_gfx_hint_align_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), x, y);
            }
        }

        private static efl_gfx_hint_align_set_delegate efl_gfx_hint_align_set_static_delegate;

        
        private delegate void efl_gfx_hint_fill_get_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.U1)] out bool x, [MarshalAs(UnmanagedType.U1)] out bool y);

        
        public delegate void efl_gfx_hint_fill_get_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.U1)] out bool x, [MarshalAs(UnmanagedType.U1)] out bool y);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_fill_get_api_delegate> efl_gfx_hint_fill_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_fill_get_api_delegate>(Module, "efl_gfx_hint_fill_get");

        private static void hint_fill_get(System.IntPtr obj, System.IntPtr pd, out bool x, out bool y)
        {
            Eina.Log.Debug("function efl_gfx_hint_fill_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                        x = default(bool);        y = default(bool);                            
                try
                {
                    ((IHint)wrapper).GetHintFill(out x, out y);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_gfx_hint_fill_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out x, out y);
            }
        }

        private static efl_gfx_hint_fill_get_delegate efl_gfx_hint_fill_get_static_delegate;

        
        private delegate void efl_gfx_hint_fill_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.U1)] bool x, [MarshalAs(UnmanagedType.U1)] bool y);

        
        public delegate void efl_gfx_hint_fill_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.U1)] bool x, [MarshalAs(UnmanagedType.U1)] bool y);

        public static Efl.Eo.FunctionWrapper<efl_gfx_hint_fill_set_api_delegate> efl_gfx_hint_fill_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_hint_fill_set_api_delegate>(Module, "efl_gfx_hint_fill_set");

        private static void hint_fill_set(System.IntPtr obj, System.IntPtr pd, bool x, bool y)
        {
            Eina.Log.Debug("function efl_gfx_hint_fill_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                            
                try
                {
                    ((IHint)wrapper).SetHintFill(x, y);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_gfx_hint_fill_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), x, y);
            }
        }

        private static efl_gfx_hint_fill_set_delegate efl_gfx_hint_fill_set_static_delegate;

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

}

