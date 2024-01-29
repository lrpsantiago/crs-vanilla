private readonly string TEAM_TAG = "XXX";                               //Your Team Tag (3 chracters), if you are not in a team yet, keep this as it is.
private readonly string DRIVER_NAME = "Guest";                          //Your name
private readonly int DRIVER_NUMBER = 99;                                //Your number (0-99)
private const string DISPLAY_NAME = "Driver LCD";
private const string MIRROR_SENSOR_RIGHT_NAME = "Mirror Sensor Right";
private const string MIRROR_SENSOR_LEFT_NAME = "Mirror Sensor Left";
private readonly int? COCKPIT_DISPLAY_INDEX = null;                     //If you wanna use a cockpit display to show dashboard info (0, 1, 2, 3 or null)
private readonly Color DEFAULT_FONT_COLOR = new Color(255, 255, 255);   //Font Color (R, G, B)
private const string TEXT_DISPLAY_NAME = "Text LCD";                    //Optional Text-Based LCD, for HudLcd Plugin
private const string RANK_DISPLAY_NAME = "Rank LCD";                    //Optional Text-Based LCD, for HudLcd Plugin
private const string TEXT_DISPLAY_HUDLCD = "hudlcd:-0.7:-0.35:0.9:White:1";
private const string RANK_DISPLAY_HUDLCD = "hudlcd:0.45:0.9:1:White:1";

string ē="12.5.0";const int Ĕ=3000;char ĕ='\u25BC';char Ė='\u25B2';char ė='\u25BA';char Ę='\u25C4';const char ę='\u2588'
;const char Ě='\u2592';const char ě='\u2591';bool Ĝ;IMyShipController ĝ;List<IMyTextSurface>Ğ;IMyTextSurface ğ;
IMyTextSurface ġ;IMyTextSurface Ġ;IMyRadioAntenna Ē;IMySensorBlock Đ;IMySensorBlock û;List<IMyGyro>ü;StringBuilder ý;G þ;long ÿ=-1;
IMyBroadcastListener Ā;int ā;DateTime Ă;float ă;bool Ą;List<MyDetectedEntityInfo>ą;List<MyDetectedEntityInfo>Ć;t ć;Program(){þ=new G();ć=new
t(new char[]{'-','\\','|','/'},150);try{ĺ();ĸ();ħ();į();Ĉ();Ĳ();ĭ();}catch(Exception ex){Ĝ=true;Echo(ex.Message);return;}
Runtime.UpdateFrequency=UpdateFrequency.Update1;Ă=DateTime.Now;}void Ĉ(){ą=new List<MyDetectedEntityInfo>();Đ=(IMySensorBlock)
GridTerminalSystem.GetBlockWithName(MIRROR_SENSOR_RIGHT_NAME);if(Đ!=null){Đ.DetectSmallShips=true;Đ.DetectLargeShips=false;Đ.DetectPlayers
=false;Đ.LeftExtend=12.5f;Đ.RightExtend=0.5f;Đ.FrontExtend=50;Đ.BackExtend=5;Đ.TopExtend=5;Đ.BottomExtend=5;}û=(
IMySensorBlock)GridTerminalSystem.GetBlockWithName(MIRROR_SENSOR_LEFT_NAME);if(û!=null){û.DetectSmallShips=true;û.DetectLargeShips=
false;û.DetectPlayers=false;û.LeftExtend=0.5f;û.RightExtend=12.5f;û.FrontExtend=50;û.BackExtend=5;û.TopExtend=5;û.
BottomExtend=5;}}void Save(){}void Main(string ĉ,UpdateType Ċ){if(Ĝ){return;}var ċ=DateTime.Now;ă=(float)(ċ-Ă).TotalMilliseconds/
1000;Echo($"Running FSESS {ē}");Ĵ(ĉ);Ď();Ģ();œ();Č();Ă=ċ;}void Č(){if(!Ą){return;}if(Vector3D.Dot(ĝ.GetNaturalGravity(),ĝ.
WorldMatrix.Up)>0){for(int č=0;č<ü.Count;č++){ü[č].GyroOverride=true;}return;}if(ü[0].GyroOverride){for(int č=0;č<ü.Count;č++){ü[č]
.GyroOverride=false;}Ą=false;}}void Ď(){var ď=IGC.UnicastListener;if(!ď.HasPendingMessage){ā-=(int)(ă*1000);if(Ā.
HasPendingMessage&&ā<=0){var ú=Ā.AcceptMessage();if(ú.Tag=="Address"){ÿ=Convert.ToInt64(ú.Data.ToString());IGC.SendUnicastMessage(ÿ,
"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ď.HasPendingMessage){var đ=ď.AcceptMessage();if(đ.Tag=="RaceData"
){þ.W(đ.Data.ToString());}if(đ.Tag=="Argument"){Ĵ(đ.Data.ToString());}}ā=Ĕ;}void Ģ(){ý.Clear();const int Ļ=21;const int ļ
=8;const int Ľ=Ļ-6;var ľ=new char[Ļ,ļ];var Þ=ĝ.GetShipSpeed();var Ŀ=$"{Math.Floor(Þ)}m/s";var ŀ=$"                     ";
var Ł=k(true);var ł=k(false);var Ń=ł.PadRight((int)Math.Ceiling((float)Ľ/2)-(int)Math.Ceiling((float)Ŀ.Length/2))+Ŀ+Ł.
PadLeft((int)Math.Floor((float)Ľ/2)-(int)Math.Floor((float)Ŀ.Length/2));ć.À(ă);var ń=$"S1{p(þ.S)}";var Ņ=$"S2{p(þ.T)}";var ņ=
$"S3{p(þ.U)}";var ň=new string[]{$"{Ń}",$"{ŀ}",$"P:{þ.H:00}/{þ.I:00} L:{(þ.J):00}/{þ.K:00}",$"TIME: {þ.L}",$"BEST: {þ.M}",
$"PREV: {þ.V}",$"               ",(ā<=0)?$" NO CONNECTION ":$"               "};for(int č=0;č<ň.Length;č++){ý.AppendLine(ň[č]);}var ŉ=
ý.ToString();foreach(var ĩ in Ğ){var Ŋ=ĩ.DrawFrame();var ŋ=Color.Black;var Ō=DEFAULT_FONT_COLOR;switch(þ.N){case Ã.Ä:ŋ=
Color.Yellow;Ō=Color.Black;break;case Ã.e:ŋ=Color.Red;Ō=Color.White;break;case Ã.a:ŋ=Color.Blue;Ō=Color.White;break;}ĩ.
BackgroundColor=ŋ;ĩ.ScriptBackgroundColor=ŋ;ĩ.FontColor=Ō;var ō=ĩ.SurfaceSize.X/256;var Ŏ=ō*0.6f;var ŏ=MySprite.CreateText(ŉ,
"Monospace",Ō,Ŏ);ŏ.Position=new Vector2(128*ō,18*ō);Ŋ.Add(ŏ);var Ő=MySprite.CreateText($"{ń}","Monospace",r(þ.S),Ŏ);Ő.Position=new
Vector2(128-64+4+1,128-4-2);var ő=MySprite.CreateText($"{Ņ}","Monospace",r(þ.T),Ŏ);ő.Position=new Vector2(128,128-4-2);var Œ=
MySprite.CreateText($"{ņ}","Monospace",r(þ.U),Ŏ);Œ.Position=new Vector2(128+64-4-2,128-4-2);Ő.Position*=ō;Ő.Size*=ō;Ŋ.Add(Ő);ő.
Position*=ō;ő.Size*=ō;Ŋ.Add(ő);Œ.Position*=ō;Œ.Size*=ō;Ŋ.Add(Œ);Ŋ.Dispose();}ý.Clear();ň[6]=$"    {ń}  {Ņ}  {ņ}    ";for(int č=0
;č<ň.Length;č++){ý.AppendLine($"{ň[č]}");}ŉ=ý.ToString();ġ?.WriteText(ŉ);ğ?.WriteText(ŉ);if(Ġ!=null&&þ!=null&&þ.R!=null){
Ġ.WriteText(þ.R);}}void œ(){if(Ē==null){return;}Ē.HudText=$"P{þ.H}";}void ĺ(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){
throw new Exception("DRIVER_NUMBER should be between 1 and 99");}var ģ=TEAM_TAG;if(TEAM_TAG==string.Empty){ģ="XXX";}ģ=ģ.Trim(
).Substring(0,3).ToUpper();Me.CubeGrid.CustomName=$"{ģ} #{DRIVER_NUMBER:00}-{DRIVER_NAME.Trim()}";}void ĸ(){var Ĥ=new
List<IMyShipController>();GridTerminalSystem.GetBlocksOfType(Ĥ);var ĥ=Ĥ.FirstOrDefault(Ħ=>Ħ is IMyRemoteControl)??Ĥ.
FirstOrDefault(Ħ=>Ħ is IMyCockpit);if(ĥ==null){throw new Exception("No cockpit or remote control!");}ĝ=ĥ;}void ħ(){ý=new StringBuilder
();Ğ=new List<IMyTextSurface>{Me.GetSurface(0)};var Ĩ=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);
if(Ĩ!=null){Ğ.Add(Ĩ);}foreach(var ĩ in Ğ){ĩ.ContentType=ContentType.SCRIPT;ĩ.Alignment=TextAlignment.CENTER;ĩ.Script=
string.Empty;}if(COCKPIT_DISPLAY_INDEX.HasValue){var Ī=ĝ as IMyCockpit;if(Ī!=null){var ĩ=Ī.GetSurface(COCKPIT_DISPLAY_INDEX.
GetValueOrDefault());if(ĩ!=null){ĩ.WriteText(string.Empty);ĩ.ContentType=ContentType.TEXT_AND_IMAGE;ĩ.Alignment=TextAlignment.CENTER;ĩ.
Font="Monospace";ğ=ĩ;}}}var ī=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(TEXT_DISPLAY_NAME);if(ī!=null){ī.WriteText
(string.Empty);ī.ContentType=ContentType.TEXT_AND_IMAGE;ī.Alignment=TextAlignment.CENTER;ī.Font="Monospace";((
IMyTerminalBlock)ī).CustomData=TEXT_DISPLAY_HUDLCD;ġ=ī;}var Ĭ=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(RANK_DISPLAY_NAME);if(
Ĭ!=null){Ĭ.WriteText(string.Empty);Ĭ.ContentType=ContentType.TEXT_AND_IMAGE;Ĭ.Alignment=TextAlignment.CENTER;Ĭ.Font=
"Monospace";((IMyTerminalBlock)Ĭ).CustomData=RANK_DISPLAY_HUDLCD;Ġ=Ĭ;}}void ĭ(){var Į=new List<IMyGyro>();GridTerminalSystem.
GetBlocksOfType(Į,j=>j.CubeGrid==Me.CubeGrid);if(Į.Count<=0){throw new Exception("No gyroscope found.");}ü=Į;}void į(){var İ=new List<
IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(İ);var ı=İ.FirstOrDefault();if(ı==null){throw new Exception("No antenna!");}ı.
Enabled=true;ı.Radius=5000;ı.EnableBroadcasting=true;ı.HudText=$"(P{þ.H}) {DRIVER_NAME}-{DRIVER_NUMBER}";Ē=ı;}void Ĳ(){IGC.
RegisterBroadcastListener("Address");var ĳ=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners(ĳ);Ā=ĳ.FirstOrDefault();}void Ĵ(string ĉ){
if(ĉ.Equals("FLIP",StringComparison.InvariantCultureIgnoreCase)){Ą=true;return;}if(ĉ.Equals("FLAG_G",StringComparison.
InvariantCultureIgnoreCase)){Ĺ(Ã.Å);return;}if(ĉ.Equals("FLAG_Y",StringComparison.InvariantCultureIgnoreCase)){Ĺ(Ã.Ä);return;}if(ĉ.Equals("FLAG_R"
,StringComparison.InvariantCultureIgnoreCase)){Ĺ(Ã.e);return;}}string ĵ(){var Ķ=string.Empty;switch(þ.N){case Ã.a:Ķ=
"Blue";break;case Ã.Å:Ķ="Green";break;case Ã.e:Ķ="Red";break;case Ã.Ä:Ķ="Yellow";break;}return Ķ;}Color ķ(){var ñ=Color.Black;
switch(þ.N){case Ã.a:ñ=Color.Blue;break;case Ã.Å:ñ=Color.Green;break;case Ã.e:ñ=Color.Red;break;case Ã.Ä:ñ=Color.Yellow;break;
}return ñ;}void Ĺ(Ã Ň){if(ÿ<=0){return;}IGC.SendUnicastMessage(ÿ,"Flag",$"{(int)Ň}");}float ù(IMySensorBlock ì){if(ì==
null||ì.Closed||!ì.IsActive){return float.MaxValue;}ą.Clear();ì.DetectedEntities(ą);if(ą.Count<=0){return float.MaxValue;}
var g=Me.CubeGrid.GetPosition();var h=ą.Select(j=>Vector3.Distance(g,j.Position)).Min();return h;}string k(bool m){var n=ù(
m?Đ:û);if(n==float.MaxValue){return string.Empty;}var o=m?ė:Ę;if(n<15){return$"{o}{o}{o}";}if(n<30){return$"{o}{o}";}
return$"{o}";}char p(B q){switch(q){case B.C:return ć.y;case B.D:return'-';case B.E:return'+';case B.F:return'*';default:
return ć.y;}}Color r(B q){switch(q){case B.C:return Color.White;case B.D:return Color.Yellow;case B.E:return Color.Lime;case B
.F:return Color.Magenta;default:return Color.White;}}class t{private char[]u;private int v;public int w{get;private set;}
public char y{get{return u[w];}}public int z{get;}public int ª{get;set;}public t(char[]µ,int º){u=µ;z=µ.Length;ª=º;}public
void À(float Á){var Â=(int)(Á*1000);v+=Â;if(v>=ª){w++;if(w==z){w=0;}v-=ª;}}public override string ToString(){return$"{y}";}}
private enum Ã{Å,Ä,e,a}private enum B{C,D,E,F}class G{public int H{get;set;}public int I{get;set;}public int J{get;set;}public
int K{get;set;}public string L{get;set;}="--:--.---";public string M{get;set;}="--:--.---";public Ã N{get;set;}public Û O{
get;set;}public int P{get;set;}public int Q{get;set;}public string R{get;set;}public B S{get;set;}public B T{get;set;}
public B U{get;set;}public string V{get;set;}="--:--.---";public void W(string X){try{var Y=X.Split(';');J=Convert.ToInt32(Y[0
]);H=Convert.ToInt32(Y[1]);L=Y[2];M=Y[3];I=Convert.ToInt32(Y[4]);K=Convert.ToInt32(Y[5]);N=(Ã)Convert.ToInt32(Y[6]);O=(Û)
Convert.ToInt32(Y[7]);P=Convert.ToInt32(Y[8]);Q=Convert.ToInt32(Y[9]);R=Y[10];S=(B)Convert.ToInt32(Y[11]);T=(B)Convert.ToInt32(
Y[12]);U=(B)Convert.ToInt32(Y[13]);V=Y[14];}catch(Exception){}}}private enum Z{A,b,Æ,ß}class à{private float á;public
char â{get;private set;}public float ã{get;set;}public float ä{get;private set;}public float å{get;private set;}public float
æ{get;private set;}public float ç{get;private set;}public float è{get{return((ã-å)/(ä-å))*100f;}}public int é{get;private
set;}public bool ê{get;private set;}public Color ë{get;private set;}private à(float ø,int í,float î,float ï,char ð,Color ñ,
bool ò=true){ä=ø;ã=ä;é=í;æ=î;ç=ï;å=(float)Math.Round(æ-((ä-æ)/(100-ç))*ç,2);â=ð;ë=ñ;ê=ò;á=(ä-å)/(60*é);}public void À(
IMyShipController ó,IMyMotorSuspension[]ô,List<IMyLightingBlock>õ,List<IMyLightingBlock>ö,G X,float Á){var Þ=ó.GetShipSpeed();if(Þ<1){
return;}var Ç=(float)MathHelper.Clamp(Þ,0,90)/90;var Ü=á*Ç*Á;ã-=Ü;ã=MathHelper.Clamp(ã,å,ä);foreach(var È in ô){È.Friction=!(ê
&&X.O==Û.Ý)?ã:ã/2;}if(è<=ç){if(ö.Any(É=>É.BlinkIntervalSeconds<=0)){foreach(var É in õ){É.BlinkIntervalSeconds=0.25f;}
foreach(var É in ö){É.BlinkIntervalSeconds=0.25f;}}}else{if(ö.Any(É=>É.BlinkIntervalSeconds>0)){foreach(var É in õ){É.
BlinkIntervalSeconds=0f;}foreach(var É in ö){É.BlinkIntervalSeconds=0f;}}}if(ã<=å){if(ô.All(È=>È.IsAttached)){var Ê=new Random().Next(4);ô[Ê
].Detach();}}}public static à Ë(){return new à(100,5,60,20,'U',new Color(192,0,255));}public static à Ì(){return new à(
100,8,50,20,'S',Color.Red);}public static à Í(){return new à(75,13,50,20,'M',Color.Yellow);}public static à Î(){return new
à(60,21,50,20,'H',Color.White);}public static à Ï(){return new à(55,34,50,20,'X',new Color(255,32,0));}public static à Ð(
){return new à(60,8,40,10,'I',Color.Green,false);}public static à Ñ(){return new à(50,21,40,10,'W',new Color(0,16,255),
false);}}private enum Ò{Ó,Ô,Õ,Ö,Ø,Ù,Ú}private enum Û{f,Ý}