package crc648f2f5d9a7dd51837;


public class SplashActivity
	extends mvvmcross.droid.support.v7.appcompat.MvxSplashScreenAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ArkhamHorrorDeckManager.Droid.Views.Splash.SplashActivity, ArkhamHorrorDeckManager.Droid", SplashActivity.class, __md_methods);
	}


	public SplashActivity ()
	{
		super ();
		if (getClass () == SplashActivity.class)
			mono.android.TypeManager.Activate ("ArkhamHorrorDeckManager.Droid.Views.Splash.SplashActivity, ArkhamHorrorDeckManager.Droid", "", this, new java.lang.Object[] {  });
	}

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
