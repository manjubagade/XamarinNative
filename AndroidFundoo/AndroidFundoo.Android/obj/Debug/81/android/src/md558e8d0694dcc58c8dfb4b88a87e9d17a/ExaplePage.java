package md558e8d0694dcc58c8dfb4b88a87e9d17a;


public class ExaplePage
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("AndroidFundoo.Droid.ExaplePage, AndroidFundoo.Android", ExaplePage.class, __md_methods);
	}


	public ExaplePage ()
	{
		super ();
		if (getClass () == ExaplePage.class)
			mono.android.TypeManager.Activate ("AndroidFundoo.Droid.ExaplePage, AndroidFundoo.Android", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
