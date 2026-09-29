# Chapter 3: Processing Data

## Objectives

Cutubkan wuxuu sharxayaa fikradaha aasaasiga ah ee **data processing** ee C# Windows Forms applications.

Marka aan dhammeeyo cutubkan, waxaan fahmi doonaa sida loo:

* Akhriyo xogta uu user-ku geliyo iyadoo la isticmaalayo TextBox controls.
* Loo sameeyo loona isticmaalo variables.
* Loola shaqeeyo data types kala duwan.
* Loo sameeyo xisaabaad aasaasi ah.
* Loo beddelo loona soo bandhigo numeric values.

## Topics labada topics aana qaadanay

* 3.1 Reading Input with TextBox Controls
* 3.2 A First Look at Variables


---

## 3.1 Reading Input with TextBox Controls

**TextBox** waa Windows Forms control loo isticmaalo in user-ku keyboard-ka kaga geliyo xogta uu rabo.

TextBox-ka waxaa laga heli karaa qaybta **Common Controls** ee ku jirta **Toolbox-ka**.

Xogta uu user-ku ku qoro TextBox-ka waxaa lagu helayaa **Text property**-ga.

csharp
string name = nameTextBox.Text;


**Text property** waxay xogta TextBox-ka u soo celisaa qaab **string** ah.

Haddii loo baahdo in TextBox-ka la nadiifiyo, waxaa loo isticmaali karaa laba siyaabood:

csharp
nameTextBox.Clear();


ama:

csharp
nameTextBox.Text = string.Empty;



## 3.2 A First Look at Variables

**Variable** waa meel gaar ah oo memory-ga ah oo program-ku u isticmaalo inuu ku kaydiyo xog.

Magaca variable-ku wuxuu noo fududeeyaa inaan xogtaas ka helno oo aan isticmaalno.

Variable-ka ka hor inta aan la isticmaalin waa in marka hore la qeexaa **data type**-kiisa.

### Syntax

csharp
DataType VariableName;


### Data Types

**Data type** wuxuu sheegaa nooca xogta variable-ku awood u leeyahay inuu kaydiyo.

Qaar ka mid ah data types-ka inta badan la isticmaalo waa:

* string waxaa lagu kaydiyaa qoraal iyo characters.
* int waxaa lagu kaydiyaa tirooyin dhan (whole numbers).
* double waxaa lagu kaydiyaa tirooyin ay ku jiri karaan decimal values.
* decimal waxaa loo isticmaalaa tirooyinka decimal-ka ah ee u baahan precision sare, waxaana si gaar ah loogu isticmaalaa xogta la xiriirta lacagaha iyo xisaabaadka.

### String Variables

**String** waa xog ka kooban characters badan oo isku xiran.

Tusaale ahaan:

csharp
string university = "Jamhuuriya University";


Strings waxaa sidoo kale la isku dari karaa iyadoo la isticmaalayo  operator.

Habkan waxaa loo yaqaan **string concatenation**.



### Variable Naming Rules

Marka variable loo sameynayo magac, waxaa jira xeerar muhiim ah oo la raaco:

* Character-ka ugu horreeya waa inuu noqdaa letter ama _.
* Magaca variable-ka laguma dhex dari karo spaces.
* Reserved keywords looma isticmaali karo magaca variable-ka.
* Waxaa fiican in variable-ka loo bixiyo magac si cad u tilmaamaya xogta uu kaydinayo.

### Local Variables and Scope

**Local variable** waa variable lagu declare-gareeyo gudaha method gaar ah.

Variable-ka noocan ah waxaa isticmaali kara oo keliya statements-ka ku jira method-ka uu variable-ku ka tirsan yahay.

**Scope** waxaa loola jeedaa qaybta program-ka uu variable-ku ka shaqayn karo ama laga isticmaali karo.

Sidoo kale, **local variable** waa in marka hore value loo assignment-gareeyo ka hor inta aan la isticmaalin.