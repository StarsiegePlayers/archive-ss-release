$Hardware::3D::Type1 = "3Dfx Chipset";
$Hardware::3D::Callback1 = "";
$Hardware::3D::Type2 = "nVidia Riva TNT Chipset";
$Hardware::3D::Callback2 = "OptionsVideo::setUpTNT();";

function OptionsVideo::setUpTNT()
{
   $pref::OpenGL::NoPackedTex    = false;
   $pref::OpenGL::NoPalettedTex	= true;
   $pref::OpenGL::TruncMode      = 2;

   flushTextureCache();
}

