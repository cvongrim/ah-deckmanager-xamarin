package crc64525c14b39e9e04ae;


public abstract class BaseActivity_1
	extends crc648d9adcc6b772c31e.MvxAppCompatActivity_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ArkhamHorrorDeckManager.Droid.Views.BaseActivity`1, ArkhamHorrorDeckManager.Droid", BaseActivity_1.class, __md_methods);
	}


	public BaseActivity_1 ()
	{
		super ();
		if (getClass () == BaseActivity_1.class)
			mono.android.TypeManager.Activate ("ArkhamHorrorDeckManager.Droid.Views.BaseActivity`1, ArkhamHorrorDeckManager.Droid", "", this, new java.lang.Object[] {  });
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
