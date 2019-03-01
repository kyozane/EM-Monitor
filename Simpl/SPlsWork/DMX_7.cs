using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_DMX_7
{
    public class UserModuleClass_DMX_7 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.AnalogInput CTRL_RED;
        Crestron.Logos.SplusObjects.AnalogInput CTRL_GREEN;
        Crestron.Logos.SplusObjects.AnalogInput CTRL_BLUE;
        Crestron.Logos.SplusObjects.AnalogInput CTRL_WHITE;
        Crestron.Logos.SplusObjects.AnalogInput CTRL_DIM;
        Crestron.Logos.SplusObjects.AnalogInput CTRL_ZOOM;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SELLIGHT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> RECALLPRESET;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> STOREPRESET;
        Crestron.Logos.SplusObjects.AnalogOutput FB_RED;
        Crestron.Logos.SplusObjects.AnalogOutput FB_GREEN;
        Crestron.Logos.SplusObjects.AnalogOutput FB_BLUE;
        Crestron.Logos.SplusObjects.AnalogOutput FB_WHITE;
        Crestron.Logos.SplusObjects.AnalogOutput FB_DIM;
        Crestron.Logos.SplusObjects.AnalogOutput FB_ZOOM;
        Crestron.Logos.SplusObjects.AnalogOutput RED1;
        Crestron.Logos.SplusObjects.AnalogOutput GREEN1;
        Crestron.Logos.SplusObjects.AnalogOutput BLUE1;
        Crestron.Logos.SplusObjects.AnalogOutput WHITE1;
        Crestron.Logos.SplusObjects.AnalogOutput DIM1;
        Crestron.Logos.SplusObjects.AnalogOutput ZOOM1;
        Crestron.Logos.SplusObjects.AnalogOutput RED2;
        Crestron.Logos.SplusObjects.AnalogOutput GREEN2;
        Crestron.Logos.SplusObjects.AnalogOutput BLUE2;
        Crestron.Logos.SplusObjects.AnalogOutput WHITE2;
        Crestron.Logos.SplusObjects.AnalogOutput DIM2;
        Crestron.Logos.SplusObjects.AnalogOutput ZOOM2;
        Crestron.Logos.SplusObjects.AnalogOutput RED3;
        Crestron.Logos.SplusObjects.AnalogOutput GREEN3;
        Crestron.Logos.SplusObjects.AnalogOutput BLUE3;
        Crestron.Logos.SplusObjects.AnalogOutput WHITE3;
        Crestron.Logos.SplusObjects.AnalogOutput DIM3;
        Crestron.Logos.SplusObjects.AnalogOutput ZOOM3;
        Crestron.Logos.SplusObjects.AnalogOutput RED4;
        Crestron.Logos.SplusObjects.AnalogOutput GREEN4;
        Crestron.Logos.SplusObjects.AnalogOutput BLUE4;
        Crestron.Logos.SplusObjects.AnalogOutput WHITE4;
        Crestron.Logos.SplusObjects.AnalogOutput DIM4;
        Crestron.Logos.SplusObjects.AnalogOutput ZOOM4;
        Crestron.Logos.SplusObjects.AnalogOutput RED5;
        Crestron.Logos.SplusObjects.AnalogOutput GREEN5;
        Crestron.Logos.SplusObjects.AnalogOutput BLUE5;
        Crestron.Logos.SplusObjects.AnalogOutput WHITE5;
        Crestron.Logos.SplusObjects.AnalogOutput DIM5;
        Crestron.Logos.SplusObjects.AnalogOutput ZOOM5;
        Crestron.Logos.SplusObjects.AnalogOutput RED6;
        Crestron.Logos.SplusObjects.AnalogOutput GREEN6;
        Crestron.Logos.SplusObjects.AnalogOutput BLUE6;
        Crestron.Logos.SplusObjects.AnalogOutput WHITE6;
        Crestron.Logos.SplusObjects.AnalogOutput DIM6;
        Crestron.Logos.SplusObjects.AnalogOutput ZOOM6;
        Crestron.Logos.SplusObjects.AnalogOutput RED7;
        Crestron.Logos.SplusObjects.AnalogOutput GREEN7;
        Crestron.Logos.SplusObjects.AnalogOutput BLUE7;
        Crestron.Logos.SplusObjects.AnalogOutput WHITE7;
        Crestron.Logos.SplusObjects.AnalogOutput DIM7;
        Crestron.Logos.SplusObjects.AnalogOutput ZOOM7;
        ushort [] LIGHTRED;
        ushort [] LIGHTGREEN;
        ushort [] LIGHTBLUE;
        ushort [] LIGHTWHITE;
        ushort [] LIGHTDIM;
        ushort [] LIGHTZOOM;
        ushort [,] PRESET;
        ushort ILIGHTSELECTED = 0;
        private void UPDATEDMX (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 146;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)ILIGHTSELECTED);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 150;
                        RED1  .Value = (ushort) ( CTRL_RED  .UshortValue ) ; 
                        __context__.SourceCodeLine = 151;
                        GREEN1  .Value = (ushort) ( CTRL_GREEN  .UshortValue ) ; 
                        __context__.SourceCodeLine = 152;
                        BLUE1  .Value = (ushort) ( CTRL_BLUE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 153;
                        WHITE1  .Value = (ushort) ( CTRL_WHITE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 154;
                        DIM1  .Value = (ushort) ( CTRL_DIM  .UshortValue ) ; 
                        __context__.SourceCodeLine = 155;
                        ZOOM1  .Value = (ushort) ( CTRL_ZOOM  .UshortValue ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 160;
                        RED2  .Value = (ushort) ( CTRL_RED  .UshortValue ) ; 
                        __context__.SourceCodeLine = 161;
                        GREEN2  .Value = (ushort) ( CTRL_GREEN  .UshortValue ) ; 
                        __context__.SourceCodeLine = 162;
                        BLUE2  .Value = (ushort) ( CTRL_BLUE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 163;
                        WHITE2  .Value = (ushort) ( CTRL_WHITE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 164;
                        DIM2  .Value = (ushort) ( CTRL_DIM  .UshortValue ) ; 
                        __context__.SourceCodeLine = 165;
                        ZOOM2  .Value = (ushort) ( CTRL_ZOOM  .UshortValue ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 170;
                        RED3  .Value = (ushort) ( CTRL_RED  .UshortValue ) ; 
                        __context__.SourceCodeLine = 171;
                        GREEN3  .Value = (ushort) ( CTRL_GREEN  .UshortValue ) ; 
                        __context__.SourceCodeLine = 172;
                        BLUE3  .Value = (ushort) ( CTRL_BLUE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 173;
                        WHITE3  .Value = (ushort) ( CTRL_WHITE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 174;
                        DIM3  .Value = (ushort) ( CTRL_DIM  .UshortValue ) ; 
                        __context__.SourceCodeLine = 175;
                        ZOOM3  .Value = (ushort) ( CTRL_ZOOM  .UshortValue ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 180;
                        RED4  .Value = (ushort) ( CTRL_RED  .UshortValue ) ; 
                        __context__.SourceCodeLine = 181;
                        GREEN4  .Value = (ushort) ( CTRL_GREEN  .UshortValue ) ; 
                        __context__.SourceCodeLine = 182;
                        BLUE4  .Value = (ushort) ( CTRL_BLUE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 183;
                        WHITE4  .Value = (ushort) ( CTRL_WHITE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 184;
                        DIM4  .Value = (ushort) ( CTRL_DIM  .UshortValue ) ; 
                        __context__.SourceCodeLine = 185;
                        ZOOM4  .Value = (ushort) ( CTRL_ZOOM  .UshortValue ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 190;
                        RED5  .Value = (ushort) ( CTRL_RED  .UshortValue ) ; 
                        __context__.SourceCodeLine = 191;
                        GREEN5  .Value = (ushort) ( CTRL_GREEN  .UshortValue ) ; 
                        __context__.SourceCodeLine = 192;
                        BLUE5  .Value = (ushort) ( CTRL_BLUE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 193;
                        WHITE5  .Value = (ushort) ( CTRL_WHITE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 194;
                        DIM5  .Value = (ushort) ( CTRL_DIM  .UshortValue ) ; 
                        __context__.SourceCodeLine = 195;
                        ZOOM5  .Value = (ushort) ( CTRL_ZOOM  .UshortValue ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 200;
                        RED6  .Value = (ushort) ( CTRL_RED  .UshortValue ) ; 
                        __context__.SourceCodeLine = 201;
                        GREEN6  .Value = (ushort) ( CTRL_GREEN  .UshortValue ) ; 
                        __context__.SourceCodeLine = 202;
                        BLUE6  .Value = (ushort) ( CTRL_BLUE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 203;
                        WHITE6  .Value = (ushort) ( CTRL_WHITE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 204;
                        DIM6  .Value = (ushort) ( CTRL_DIM  .UshortValue ) ; 
                        __context__.SourceCodeLine = 205;
                        ZOOM6  .Value = (ushort) ( CTRL_ZOOM  .UshortValue ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 210;
                        RED7  .Value = (ushort) ( CTRL_RED  .UshortValue ) ; 
                        __context__.SourceCodeLine = 211;
                        GREEN7  .Value = (ushort) ( CTRL_GREEN  .UshortValue ) ; 
                        __context__.SourceCodeLine = 212;
                        BLUE7  .Value = (ushort) ( CTRL_BLUE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 213;
                        WHITE7  .Value = (ushort) ( CTRL_WHITE  .UshortValue ) ; 
                        __context__.SourceCodeLine = 214;
                        DIM7  .Value = (ushort) ( CTRL_DIM  .UshortValue ) ; 
                        __context__.SourceCodeLine = 215;
                        ZOOM7  .Value = (ushort) ( CTRL_ZOOM  .UshortValue ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void UPDATEFB (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 223;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)ILIGHTSELECTED);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 227;
                        FB_RED  .Value = (ushort) ( RED1  .Value ) ; 
                        __context__.SourceCodeLine = 228;
                        FB_GREEN  .Value = (ushort) ( GREEN1  .Value ) ; 
                        __context__.SourceCodeLine = 229;
                        FB_BLUE  .Value = (ushort) ( BLUE1  .Value ) ; 
                        __context__.SourceCodeLine = 230;
                        FB_WHITE  .Value = (ushort) ( WHITE1  .Value ) ; 
                        __context__.SourceCodeLine = 231;
                        FB_DIM  .Value = (ushort) ( DIM1  .Value ) ; 
                        __context__.SourceCodeLine = 232;
                        FB_ZOOM  .Value = (ushort) ( ZOOM1  .Value ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 237;
                        FB_RED  .Value = (ushort) ( RED2  .Value ) ; 
                        __context__.SourceCodeLine = 238;
                        FB_GREEN  .Value = (ushort) ( GREEN2  .Value ) ; 
                        __context__.SourceCodeLine = 239;
                        FB_BLUE  .Value = (ushort) ( BLUE2  .Value ) ; 
                        __context__.SourceCodeLine = 240;
                        FB_WHITE  .Value = (ushort) ( WHITE2  .Value ) ; 
                        __context__.SourceCodeLine = 241;
                        FB_DIM  .Value = (ushort) ( DIM2  .Value ) ; 
                        __context__.SourceCodeLine = 242;
                        FB_ZOOM  .Value = (ushort) ( ZOOM2  .Value ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 247;
                        FB_RED  .Value = (ushort) ( RED3  .Value ) ; 
                        __context__.SourceCodeLine = 248;
                        FB_GREEN  .Value = (ushort) ( GREEN3  .Value ) ; 
                        __context__.SourceCodeLine = 249;
                        FB_BLUE  .Value = (ushort) ( BLUE3  .Value ) ; 
                        __context__.SourceCodeLine = 250;
                        FB_WHITE  .Value = (ushort) ( WHITE3  .Value ) ; 
                        __context__.SourceCodeLine = 251;
                        FB_DIM  .Value = (ushort) ( DIM3  .Value ) ; 
                        __context__.SourceCodeLine = 252;
                        FB_ZOOM  .Value = (ushort) ( ZOOM3  .Value ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 257;
                        FB_RED  .Value = (ushort) ( RED4  .Value ) ; 
                        __context__.SourceCodeLine = 258;
                        FB_GREEN  .Value = (ushort) ( GREEN4  .Value ) ; 
                        __context__.SourceCodeLine = 259;
                        FB_BLUE  .Value = (ushort) ( BLUE4  .Value ) ; 
                        __context__.SourceCodeLine = 260;
                        FB_WHITE  .Value = (ushort) ( WHITE4  .Value ) ; 
                        __context__.SourceCodeLine = 261;
                        FB_DIM  .Value = (ushort) ( DIM4  .Value ) ; 
                        __context__.SourceCodeLine = 262;
                        FB_ZOOM  .Value = (ushort) ( ZOOM4  .Value ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 267;
                        FB_RED  .Value = (ushort) ( RED5  .Value ) ; 
                        __context__.SourceCodeLine = 268;
                        FB_GREEN  .Value = (ushort) ( GREEN5  .Value ) ; 
                        __context__.SourceCodeLine = 269;
                        FB_BLUE  .Value = (ushort) ( BLUE5  .Value ) ; 
                        __context__.SourceCodeLine = 270;
                        FB_WHITE  .Value = (ushort) ( WHITE5  .Value ) ; 
                        __context__.SourceCodeLine = 271;
                        FB_DIM  .Value = (ushort) ( DIM5  .Value ) ; 
                        __context__.SourceCodeLine = 272;
                        FB_ZOOM  .Value = (ushort) ( ZOOM5  .Value ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 277;
                        FB_RED  .Value = (ushort) ( RED6  .Value ) ; 
                        __context__.SourceCodeLine = 278;
                        FB_GREEN  .Value = (ushort) ( GREEN6  .Value ) ; 
                        __context__.SourceCodeLine = 279;
                        FB_BLUE  .Value = (ushort) ( BLUE6  .Value ) ; 
                        __context__.SourceCodeLine = 280;
                        FB_WHITE  .Value = (ushort) ( WHITE6  .Value ) ; 
                        __context__.SourceCodeLine = 281;
                        FB_DIM  .Value = (ushort) ( DIM6  .Value ) ; 
                        __context__.SourceCodeLine = 282;
                        FB_ZOOM  .Value = (ushort) ( ZOOM6  .Value ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 287;
                        FB_RED  .Value = (ushort) ( RED7  .Value ) ; 
                        __context__.SourceCodeLine = 288;
                        FB_GREEN  .Value = (ushort) ( GREEN7  .Value ) ; 
                        __context__.SourceCodeLine = 289;
                        FB_BLUE  .Value = (ushort) ( BLUE7  .Value ) ; 
                        __context__.SourceCodeLine = 290;
                        FB_WHITE  .Value = (ushort) ( WHITE7  .Value ) ; 
                        __context__.SourceCodeLine = 291;
                        FB_DIM  .Value = (ushort) ( DIM7  .Value ) ; 
                        __context__.SourceCodeLine = 292;
                        FB_ZOOM  .Value = (ushort) ( ZOOM7  .Value ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        object CTRL_RED_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 356;
                FB_RED  .Value = (ushort) ( CTRL_RED  .UshortValue ) ; 
                __context__.SourceCodeLine = 357;
                LIGHTRED [ ILIGHTSELECTED] = (ushort) ( CTRL_RED  .UshortValue ) ; 
                __context__.SourceCodeLine = 359;
                UPDATEDMX (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CTRL_GREEN_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 365;
            FB_GREEN  .Value = (ushort) ( CTRL_GREEN  .UshortValue ) ; 
            __context__.SourceCodeLine = 366;
            LIGHTGREEN [ ILIGHTSELECTED] = (ushort) ( CTRL_GREEN  .UshortValue ) ; 
            __context__.SourceCodeLine = 368;
            UPDATEDMX (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object CTRL_BLUE_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 374;
        FB_BLUE  .Value = (ushort) ( CTRL_BLUE  .UshortValue ) ; 
        __context__.SourceCodeLine = 375;
        LIGHTBLUE [ ILIGHTSELECTED] = (ushort) ( CTRL_BLUE  .UshortValue ) ; 
        __context__.SourceCodeLine = 377;
        UPDATEDMX (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CTRL_WHITE_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 383;
        FB_WHITE  .Value = (ushort) ( CTRL_WHITE  .UshortValue ) ; 
        __context__.SourceCodeLine = 384;
        LIGHTWHITE [ ILIGHTSELECTED] = (ushort) ( CTRL_WHITE  .UshortValue ) ; 
        __context__.SourceCodeLine = 386;
        UPDATEDMX (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CTRL_DIM_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 392;
        FB_DIM  .Value = (ushort) ( CTRL_DIM  .UshortValue ) ; 
        __context__.SourceCodeLine = 393;
        LIGHTDIM [ ILIGHTSELECTED] = (ushort) ( CTRL_DIM  .UshortValue ) ; 
        __context__.SourceCodeLine = 395;
        UPDATEDMX (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CTRL_ZOOM_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 401;
        LIGHTZOOM [ ILIGHTSELECTED] = (ushort) ( CTRL_ZOOM  .UshortValue ) ; 
        __context__.SourceCodeLine = 402;
        FB_ZOOM  .Value = (ushort) ( CTRL_ZOOM  .UshortValue ) ; 
        __context__.SourceCodeLine = 404;
        UPDATEDMX (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELLIGHT_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 412;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)6; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 414;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SELLIGHT[ (I + 1) ] .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 416;
                ILIGHTSELECTED = (ushort) ( I ) ; 
                __context__.SourceCodeLine = 418;
                FB_RED  .Value = (ushort) ( LIGHTRED[ I ] ) ; 
                __context__.SourceCodeLine = 419;
                FB_GREEN  .Value = (ushort) ( LIGHTGREEN[ I ] ) ; 
                __context__.SourceCodeLine = 420;
                FB_BLUE  .Value = (ushort) ( LIGHTBLUE[ I ] ) ; 
                __context__.SourceCodeLine = 421;
                FB_WHITE  .Value = (ushort) ( LIGHTWHITE[ I ] ) ; 
                __context__.SourceCodeLine = 422;
                FB_DIM  .Value = (ushort) ( LIGHTDIM[ I ] ) ; 
                __context__.SourceCodeLine = 423;
                FB_ZOOM  .Value = (ushort) ( LIGHTZOOM[ I ] ) ; 
                __context__.SourceCodeLine = 424;
                break ; 
                } 
            
            __context__.SourceCodeLine = 412;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECALLPRESET_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 434;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)7; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 436;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RECALLPRESET[ I ] .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 438;
                RED1  .Value = (ushort) ( PRESET[ (I - 1) , 0 ] ) ; 
                __context__.SourceCodeLine = 439;
                GREEN1  .Value = (ushort) ( PRESET[ (I - 1) , 1 ] ) ; 
                __context__.SourceCodeLine = 440;
                BLUE1  .Value = (ushort) ( PRESET[ (I - 1) , 2 ] ) ; 
                __context__.SourceCodeLine = 441;
                WHITE1  .Value = (ushort) ( PRESET[ (I - 1) , 3 ] ) ; 
                __context__.SourceCodeLine = 442;
                DIM1  .Value = (ushort) ( PRESET[ (I - 1) , 4 ] ) ; 
                __context__.SourceCodeLine = 443;
                ZOOM1  .Value = (ushort) ( PRESET[ (I - 1) , 5 ] ) ; 
                __context__.SourceCodeLine = 445;
                RED2  .Value = (ushort) ( PRESET[ (I - 1) , 6 ] ) ; 
                __context__.SourceCodeLine = 446;
                GREEN2  .Value = (ushort) ( PRESET[ (I - 1) , 7 ] ) ; 
                __context__.SourceCodeLine = 447;
                BLUE2  .Value = (ushort) ( PRESET[ (I - 1) , 8 ] ) ; 
                __context__.SourceCodeLine = 448;
                WHITE2  .Value = (ushort) ( PRESET[ (I - 1) , 9 ] ) ; 
                __context__.SourceCodeLine = 449;
                DIM2  .Value = (ushort) ( PRESET[ (I - 1) , 10 ] ) ; 
                __context__.SourceCodeLine = 450;
                ZOOM2  .Value = (ushort) ( PRESET[ (I - 1) , 11 ] ) ; 
                __context__.SourceCodeLine = 452;
                RED3  .Value = (ushort) ( PRESET[ (I - 1) , 12 ] ) ; 
                __context__.SourceCodeLine = 453;
                GREEN3  .Value = (ushort) ( PRESET[ (I - 1) , 13 ] ) ; 
                __context__.SourceCodeLine = 454;
                BLUE3  .Value = (ushort) ( PRESET[ (I - 1) , 14 ] ) ; 
                __context__.SourceCodeLine = 455;
                WHITE3  .Value = (ushort) ( PRESET[ (I - 1) , 15 ] ) ; 
                __context__.SourceCodeLine = 456;
                DIM3  .Value = (ushort) ( PRESET[ (I - 1) , 16 ] ) ; 
                __context__.SourceCodeLine = 457;
                ZOOM3  .Value = (ushort) ( PRESET[ (I - 1) , 17 ] ) ; 
                __context__.SourceCodeLine = 459;
                RED4  .Value = (ushort) ( PRESET[ (I - 1) , 18 ] ) ; 
                __context__.SourceCodeLine = 460;
                GREEN4  .Value = (ushort) ( PRESET[ (I - 1) , 19 ] ) ; 
                __context__.SourceCodeLine = 461;
                BLUE4  .Value = (ushort) ( PRESET[ (I - 1) , 20 ] ) ; 
                __context__.SourceCodeLine = 462;
                WHITE4  .Value = (ushort) ( PRESET[ (I - 1) , 21 ] ) ; 
                __context__.SourceCodeLine = 463;
                DIM4  .Value = (ushort) ( PRESET[ (I - 1) , 22 ] ) ; 
                __context__.SourceCodeLine = 464;
                ZOOM4  .Value = (ushort) ( PRESET[ (I - 1) , 23 ] ) ; 
                __context__.SourceCodeLine = 466;
                RED5  .Value = (ushort) ( PRESET[ (I - 1) , 24 ] ) ; 
                __context__.SourceCodeLine = 467;
                GREEN5  .Value = (ushort) ( PRESET[ (I - 1) , 25 ] ) ; 
                __context__.SourceCodeLine = 468;
                BLUE5  .Value = (ushort) ( PRESET[ (I - 1) , 26 ] ) ; 
                __context__.SourceCodeLine = 469;
                WHITE5  .Value = (ushort) ( PRESET[ (I - 1) , 27 ] ) ; 
                __context__.SourceCodeLine = 470;
                DIM5  .Value = (ushort) ( PRESET[ (I - 1) , 28 ] ) ; 
                __context__.SourceCodeLine = 471;
                ZOOM5  .Value = (ushort) ( PRESET[ (I - 1) , 29 ] ) ; 
                __context__.SourceCodeLine = 473;
                RED6  .Value = (ushort) ( PRESET[ (I - 1) , 30 ] ) ; 
                __context__.SourceCodeLine = 474;
                GREEN6  .Value = (ushort) ( PRESET[ (I - 1) , 31 ] ) ; 
                __context__.SourceCodeLine = 475;
                BLUE6  .Value = (ushort) ( PRESET[ (I - 1) , 32 ] ) ; 
                __context__.SourceCodeLine = 476;
                WHITE6  .Value = (ushort) ( PRESET[ (I - 1) , 33 ] ) ; 
                __context__.SourceCodeLine = 477;
                DIM6  .Value = (ushort) ( PRESET[ (I - 1) , 34 ] ) ; 
                __context__.SourceCodeLine = 478;
                ZOOM6  .Value = (ushort) ( PRESET[ (I - 1) , 35 ] ) ; 
                __context__.SourceCodeLine = 480;
                RED7  .Value = (ushort) ( PRESET[ (I - 1) , 36 ] ) ; 
                __context__.SourceCodeLine = 481;
                GREEN7  .Value = (ushort) ( PRESET[ (I - 1) , 37 ] ) ; 
                __context__.SourceCodeLine = 482;
                BLUE7  .Value = (ushort) ( PRESET[ (I - 1) , 38 ] ) ; 
                __context__.SourceCodeLine = 483;
                WHITE7  .Value = (ushort) ( PRESET[ (I - 1) , 39 ] ) ; 
                __context__.SourceCodeLine = 484;
                DIM7  .Value = (ushort) ( PRESET[ (I - 1) , 40 ] ) ; 
                __context__.SourceCodeLine = 485;
                ZOOM7  .Value = (ushort) ( PRESET[ (I - 1) , 41 ] ) ; 
                __context__.SourceCodeLine = 487;
                UPDATEFB (  __context__  ) ; 
                } 
            
            __context__.SourceCodeLine = 434;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOREPRESET_OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        
        __context__.SourceCodeLine = 497;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)7; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 499;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STOREPRESET[ I ] .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 501;
                PRESET [ (I - 1) , 0] = (ushort) ( RED1  .Value ) ; 
                __context__.SourceCodeLine = 502;
                PRESET [ (I - 1) , 1] = (ushort) ( GREEN1  .Value ) ; 
                __context__.SourceCodeLine = 503;
                PRESET [ (I - 1) , 2] = (ushort) ( BLUE1  .Value ) ; 
                __context__.SourceCodeLine = 504;
                PRESET [ (I - 1) , 3] = (ushort) ( WHITE1  .Value ) ; 
                __context__.SourceCodeLine = 505;
                PRESET [ (I - 1) , 4] = (ushort) ( DIM1  .Value ) ; 
                __context__.SourceCodeLine = 506;
                PRESET [ (I - 1) , 5] = (ushort) ( ZOOM1  .Value ) ; 
                __context__.SourceCodeLine = 508;
                PRESET [ (I - 1) , 6] = (ushort) ( RED2  .Value ) ; 
                __context__.SourceCodeLine = 509;
                PRESET [ (I - 1) , 7] = (ushort) ( GREEN2  .Value ) ; 
                __context__.SourceCodeLine = 510;
                PRESET [ (I - 1) , 8] = (ushort) ( BLUE2  .Value ) ; 
                __context__.SourceCodeLine = 511;
                PRESET [ (I - 1) , 9] = (ushort) ( WHITE2  .Value ) ; 
                __context__.SourceCodeLine = 512;
                PRESET [ (I - 1) , 10] = (ushort) ( DIM2  .Value ) ; 
                __context__.SourceCodeLine = 513;
                PRESET [ (I - 1) , 11] = (ushort) ( ZOOM2  .Value ) ; 
                __context__.SourceCodeLine = 515;
                PRESET [ (I - 1) , 12] = (ushort) ( RED3  .Value ) ; 
                __context__.SourceCodeLine = 516;
                PRESET [ (I - 1) , 13] = (ushort) ( GREEN3  .Value ) ; 
                __context__.SourceCodeLine = 517;
                PRESET [ (I - 1) , 14] = (ushort) ( BLUE3  .Value ) ; 
                __context__.SourceCodeLine = 518;
                PRESET [ (I - 1) , 15] = (ushort) ( WHITE3  .Value ) ; 
                __context__.SourceCodeLine = 519;
                PRESET [ (I - 1) , 16] = (ushort) ( DIM3  .Value ) ; 
                __context__.SourceCodeLine = 520;
                PRESET [ (I - 1) , 17] = (ushort) ( ZOOM3  .Value ) ; 
                __context__.SourceCodeLine = 522;
                PRESET [ (I - 1) , 18] = (ushort) ( RED4  .Value ) ; 
                __context__.SourceCodeLine = 523;
                PRESET [ (I - 1) , 19] = (ushort) ( GREEN4  .Value ) ; 
                __context__.SourceCodeLine = 524;
                PRESET [ (I - 1) , 20] = (ushort) ( BLUE4  .Value ) ; 
                __context__.SourceCodeLine = 525;
                PRESET [ (I - 1) , 21] = (ushort) ( WHITE4  .Value ) ; 
                __context__.SourceCodeLine = 526;
                PRESET [ (I - 1) , 22] = (ushort) ( DIM4  .Value ) ; 
                __context__.SourceCodeLine = 527;
                PRESET [ (I - 1) , 23] = (ushort) ( ZOOM4  .Value ) ; 
                __context__.SourceCodeLine = 529;
                PRESET [ (I - 1) , 24] = (ushort) ( RED5  .Value ) ; 
                __context__.SourceCodeLine = 530;
                PRESET [ (I - 1) , 25] = (ushort) ( GREEN5  .Value ) ; 
                __context__.SourceCodeLine = 531;
                PRESET [ (I - 1) , 26] = (ushort) ( BLUE5  .Value ) ; 
                __context__.SourceCodeLine = 532;
                PRESET [ (I - 1) , 27] = (ushort) ( WHITE5  .Value ) ; 
                __context__.SourceCodeLine = 533;
                PRESET [ (I - 1) , 28] = (ushort) ( DIM5  .Value ) ; 
                __context__.SourceCodeLine = 534;
                PRESET [ (I - 1) , 29] = (ushort) ( ZOOM5  .Value ) ; 
                __context__.SourceCodeLine = 536;
                PRESET [ (I - 1) , 30] = (ushort) ( RED6  .Value ) ; 
                __context__.SourceCodeLine = 537;
                PRESET [ (I - 1) , 31] = (ushort) ( GREEN6  .Value ) ; 
                __context__.SourceCodeLine = 538;
                PRESET [ (I - 1) , 32] = (ushort) ( BLUE6  .Value ) ; 
                __context__.SourceCodeLine = 539;
                PRESET [ (I - 1) , 33] = (ushort) ( WHITE6  .Value ) ; 
                __context__.SourceCodeLine = 540;
                PRESET [ (I - 1) , 34] = (ushort) ( DIM6  .Value ) ; 
                __context__.SourceCodeLine = 541;
                PRESET [ (I - 1) , 35] = (ushort) ( ZOOM6  .Value ) ; 
                __context__.SourceCodeLine = 543;
                PRESET [ (I - 1) , 36] = (ushort) ( RED7  .Value ) ; 
                __context__.SourceCodeLine = 544;
                PRESET [ (I - 1) , 37] = (ushort) ( GREEN7  .Value ) ; 
                __context__.SourceCodeLine = 545;
                PRESET [ (I - 1) , 38] = (ushort) ( BLUE7  .Value ) ; 
                __context__.SourceCodeLine = 546;
                PRESET [ (I - 1) , 39] = (ushort) ( WHITE7  .Value ) ; 
                __context__.SourceCodeLine = 547;
                PRESET [ (I - 1) , 40] = (ushort) ( DIM7  .Value ) ; 
                __context__.SourceCodeLine = 548;
                PRESET [ (I - 1) , 41] = (ushort) ( ZOOM7  .Value ) ; 
                } 
            
            __context__.SourceCodeLine = 497;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 606;
        ILIGHTSELECTED = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    LIGHTRED  = new ushort[ 8 ];
    LIGHTGREEN  = new ushort[ 8 ];
    LIGHTBLUE  = new ushort[ 8 ];
    LIGHTWHITE  = new ushort[ 8 ];
    LIGHTDIM  = new ushort[ 8 ];
    LIGHTZOOM  = new ushort[ 8 ];
    PRESET  = new ushort[ 8,43 ];
    
    SELLIGHT = new InOutArray<DigitalInput>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        SELLIGHT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SELLIGHT__DigitalInput__ + i, SELLIGHT__DigitalInput__, this );
        m_DigitalInputList.Add( SELLIGHT__DigitalInput__ + i, SELLIGHT[i+1] );
    }
    
    RECALLPRESET = new InOutArray<DigitalInput>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        RECALLPRESET[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( RECALLPRESET__DigitalInput__ + i, RECALLPRESET__DigitalInput__, this );
        m_DigitalInputList.Add( RECALLPRESET__DigitalInput__ + i, RECALLPRESET[i+1] );
    }
    
    STOREPRESET = new InOutArray<DigitalInput>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        STOREPRESET[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( STOREPRESET__DigitalInput__ + i, STOREPRESET__DigitalInput__, this );
        m_DigitalInputList.Add( STOREPRESET__DigitalInput__ + i, STOREPRESET[i+1] );
    }
    
    CTRL_RED = new Crestron.Logos.SplusObjects.AnalogInput( CTRL_RED__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CTRL_RED__AnalogSerialInput__, CTRL_RED );
    
    CTRL_GREEN = new Crestron.Logos.SplusObjects.AnalogInput( CTRL_GREEN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CTRL_GREEN__AnalogSerialInput__, CTRL_GREEN );
    
    CTRL_BLUE = new Crestron.Logos.SplusObjects.AnalogInput( CTRL_BLUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CTRL_BLUE__AnalogSerialInput__, CTRL_BLUE );
    
    CTRL_WHITE = new Crestron.Logos.SplusObjects.AnalogInput( CTRL_WHITE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CTRL_WHITE__AnalogSerialInput__, CTRL_WHITE );
    
    CTRL_DIM = new Crestron.Logos.SplusObjects.AnalogInput( CTRL_DIM__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CTRL_DIM__AnalogSerialInput__, CTRL_DIM );
    
    CTRL_ZOOM = new Crestron.Logos.SplusObjects.AnalogInput( CTRL_ZOOM__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CTRL_ZOOM__AnalogSerialInput__, CTRL_ZOOM );
    
    FB_RED = new Crestron.Logos.SplusObjects.AnalogOutput( FB_RED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FB_RED__AnalogSerialOutput__, FB_RED );
    
    FB_GREEN = new Crestron.Logos.SplusObjects.AnalogOutput( FB_GREEN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FB_GREEN__AnalogSerialOutput__, FB_GREEN );
    
    FB_BLUE = new Crestron.Logos.SplusObjects.AnalogOutput( FB_BLUE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FB_BLUE__AnalogSerialOutput__, FB_BLUE );
    
    FB_WHITE = new Crestron.Logos.SplusObjects.AnalogOutput( FB_WHITE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FB_WHITE__AnalogSerialOutput__, FB_WHITE );
    
    FB_DIM = new Crestron.Logos.SplusObjects.AnalogOutput( FB_DIM__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FB_DIM__AnalogSerialOutput__, FB_DIM );
    
    FB_ZOOM = new Crestron.Logos.SplusObjects.AnalogOutput( FB_ZOOM__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FB_ZOOM__AnalogSerialOutput__, FB_ZOOM );
    
    RED1 = new Crestron.Logos.SplusObjects.AnalogOutput( RED1__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RED1__AnalogSerialOutput__, RED1 );
    
    GREEN1 = new Crestron.Logos.SplusObjects.AnalogOutput( GREEN1__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GREEN1__AnalogSerialOutput__, GREEN1 );
    
    BLUE1 = new Crestron.Logos.SplusObjects.AnalogOutput( BLUE1__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BLUE1__AnalogSerialOutput__, BLUE1 );
    
    WHITE1 = new Crestron.Logos.SplusObjects.AnalogOutput( WHITE1__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WHITE1__AnalogSerialOutput__, WHITE1 );
    
    DIM1 = new Crestron.Logos.SplusObjects.AnalogOutput( DIM1__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DIM1__AnalogSerialOutput__, DIM1 );
    
    ZOOM1 = new Crestron.Logos.SplusObjects.AnalogOutput( ZOOM1__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZOOM1__AnalogSerialOutput__, ZOOM1 );
    
    RED2 = new Crestron.Logos.SplusObjects.AnalogOutput( RED2__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RED2__AnalogSerialOutput__, RED2 );
    
    GREEN2 = new Crestron.Logos.SplusObjects.AnalogOutput( GREEN2__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GREEN2__AnalogSerialOutput__, GREEN2 );
    
    BLUE2 = new Crestron.Logos.SplusObjects.AnalogOutput( BLUE2__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BLUE2__AnalogSerialOutput__, BLUE2 );
    
    WHITE2 = new Crestron.Logos.SplusObjects.AnalogOutput( WHITE2__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WHITE2__AnalogSerialOutput__, WHITE2 );
    
    DIM2 = new Crestron.Logos.SplusObjects.AnalogOutput( DIM2__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DIM2__AnalogSerialOutput__, DIM2 );
    
    ZOOM2 = new Crestron.Logos.SplusObjects.AnalogOutput( ZOOM2__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZOOM2__AnalogSerialOutput__, ZOOM2 );
    
    RED3 = new Crestron.Logos.SplusObjects.AnalogOutput( RED3__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RED3__AnalogSerialOutput__, RED3 );
    
    GREEN3 = new Crestron.Logos.SplusObjects.AnalogOutput( GREEN3__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GREEN3__AnalogSerialOutput__, GREEN3 );
    
    BLUE3 = new Crestron.Logos.SplusObjects.AnalogOutput( BLUE3__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BLUE3__AnalogSerialOutput__, BLUE3 );
    
    WHITE3 = new Crestron.Logos.SplusObjects.AnalogOutput( WHITE3__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WHITE3__AnalogSerialOutput__, WHITE3 );
    
    DIM3 = new Crestron.Logos.SplusObjects.AnalogOutput( DIM3__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DIM3__AnalogSerialOutput__, DIM3 );
    
    ZOOM3 = new Crestron.Logos.SplusObjects.AnalogOutput( ZOOM3__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZOOM3__AnalogSerialOutput__, ZOOM3 );
    
    RED4 = new Crestron.Logos.SplusObjects.AnalogOutput( RED4__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RED4__AnalogSerialOutput__, RED4 );
    
    GREEN4 = new Crestron.Logos.SplusObjects.AnalogOutput( GREEN4__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GREEN4__AnalogSerialOutput__, GREEN4 );
    
    BLUE4 = new Crestron.Logos.SplusObjects.AnalogOutput( BLUE4__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BLUE4__AnalogSerialOutput__, BLUE4 );
    
    WHITE4 = new Crestron.Logos.SplusObjects.AnalogOutput( WHITE4__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WHITE4__AnalogSerialOutput__, WHITE4 );
    
    DIM4 = new Crestron.Logos.SplusObjects.AnalogOutput( DIM4__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DIM4__AnalogSerialOutput__, DIM4 );
    
    ZOOM4 = new Crestron.Logos.SplusObjects.AnalogOutput( ZOOM4__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZOOM4__AnalogSerialOutput__, ZOOM4 );
    
    RED5 = new Crestron.Logos.SplusObjects.AnalogOutput( RED5__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RED5__AnalogSerialOutput__, RED5 );
    
    GREEN5 = new Crestron.Logos.SplusObjects.AnalogOutput( GREEN5__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GREEN5__AnalogSerialOutput__, GREEN5 );
    
    BLUE5 = new Crestron.Logos.SplusObjects.AnalogOutput( BLUE5__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BLUE5__AnalogSerialOutput__, BLUE5 );
    
    WHITE5 = new Crestron.Logos.SplusObjects.AnalogOutput( WHITE5__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WHITE5__AnalogSerialOutput__, WHITE5 );
    
    DIM5 = new Crestron.Logos.SplusObjects.AnalogOutput( DIM5__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DIM5__AnalogSerialOutput__, DIM5 );
    
    ZOOM5 = new Crestron.Logos.SplusObjects.AnalogOutput( ZOOM5__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZOOM5__AnalogSerialOutput__, ZOOM5 );
    
    RED6 = new Crestron.Logos.SplusObjects.AnalogOutput( RED6__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RED6__AnalogSerialOutput__, RED6 );
    
    GREEN6 = new Crestron.Logos.SplusObjects.AnalogOutput( GREEN6__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GREEN6__AnalogSerialOutput__, GREEN6 );
    
    BLUE6 = new Crestron.Logos.SplusObjects.AnalogOutput( BLUE6__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BLUE6__AnalogSerialOutput__, BLUE6 );
    
    WHITE6 = new Crestron.Logos.SplusObjects.AnalogOutput( WHITE6__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WHITE6__AnalogSerialOutput__, WHITE6 );
    
    DIM6 = new Crestron.Logos.SplusObjects.AnalogOutput( DIM6__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DIM6__AnalogSerialOutput__, DIM6 );
    
    ZOOM6 = new Crestron.Logos.SplusObjects.AnalogOutput( ZOOM6__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZOOM6__AnalogSerialOutput__, ZOOM6 );
    
    RED7 = new Crestron.Logos.SplusObjects.AnalogOutput( RED7__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( RED7__AnalogSerialOutput__, RED7 );
    
    GREEN7 = new Crestron.Logos.SplusObjects.AnalogOutput( GREEN7__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GREEN7__AnalogSerialOutput__, GREEN7 );
    
    BLUE7 = new Crestron.Logos.SplusObjects.AnalogOutput( BLUE7__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BLUE7__AnalogSerialOutput__, BLUE7 );
    
    WHITE7 = new Crestron.Logos.SplusObjects.AnalogOutput( WHITE7__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WHITE7__AnalogSerialOutput__, WHITE7 );
    
    DIM7 = new Crestron.Logos.SplusObjects.AnalogOutput( DIM7__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DIM7__AnalogSerialOutput__, DIM7 );
    
    ZOOM7 = new Crestron.Logos.SplusObjects.AnalogOutput( ZOOM7__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZOOM7__AnalogSerialOutput__, ZOOM7 );
    
    
    CTRL_RED.OnAnalogChange.Add( new InputChangeHandlerWrapper( CTRL_RED_OnChange_0, false ) );
    CTRL_GREEN.OnAnalogChange.Add( new InputChangeHandlerWrapper( CTRL_GREEN_OnChange_1, false ) );
    CTRL_BLUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( CTRL_BLUE_OnChange_2, false ) );
    CTRL_WHITE.OnAnalogChange.Add( new InputChangeHandlerWrapper( CTRL_WHITE_OnChange_3, false ) );
    CTRL_DIM.OnAnalogChange.Add( new InputChangeHandlerWrapper( CTRL_DIM_OnChange_4, false ) );
    CTRL_ZOOM.OnAnalogChange.Add( new InputChangeHandlerWrapper( CTRL_ZOOM_OnChange_5, false ) );
    for( uint i = 0; i < 7; i++ )
        SELLIGHT[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( SELLIGHT_OnChange_6, false ) );
        
    for( uint i = 0; i < 7; i++ )
        RECALLPRESET[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( RECALLPRESET_OnChange_7, false ) );
        
    for( uint i = 0; i < 7; i++ )
        STOREPRESET[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( STOREPRESET_OnChange_8, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_DMX_7 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CTRL_RED__AnalogSerialInput__ = 0;
const uint CTRL_GREEN__AnalogSerialInput__ = 1;
const uint CTRL_BLUE__AnalogSerialInput__ = 2;
const uint CTRL_WHITE__AnalogSerialInput__ = 3;
const uint CTRL_DIM__AnalogSerialInput__ = 4;
const uint CTRL_ZOOM__AnalogSerialInput__ = 5;
const uint SELLIGHT__DigitalInput__ = 0;
const uint RECALLPRESET__DigitalInput__ = 7;
const uint STOREPRESET__DigitalInput__ = 14;
const uint FB_RED__AnalogSerialOutput__ = 0;
const uint FB_GREEN__AnalogSerialOutput__ = 1;
const uint FB_BLUE__AnalogSerialOutput__ = 2;
const uint FB_WHITE__AnalogSerialOutput__ = 3;
const uint FB_DIM__AnalogSerialOutput__ = 4;
const uint FB_ZOOM__AnalogSerialOutput__ = 5;
const uint RED1__AnalogSerialOutput__ = 6;
const uint GREEN1__AnalogSerialOutput__ = 7;
const uint BLUE1__AnalogSerialOutput__ = 8;
const uint WHITE1__AnalogSerialOutput__ = 9;
const uint DIM1__AnalogSerialOutput__ = 10;
const uint ZOOM1__AnalogSerialOutput__ = 11;
const uint RED2__AnalogSerialOutput__ = 12;
const uint GREEN2__AnalogSerialOutput__ = 13;
const uint BLUE2__AnalogSerialOutput__ = 14;
const uint WHITE2__AnalogSerialOutput__ = 15;
const uint DIM2__AnalogSerialOutput__ = 16;
const uint ZOOM2__AnalogSerialOutput__ = 17;
const uint RED3__AnalogSerialOutput__ = 18;
const uint GREEN3__AnalogSerialOutput__ = 19;
const uint BLUE3__AnalogSerialOutput__ = 20;
const uint WHITE3__AnalogSerialOutput__ = 21;
const uint DIM3__AnalogSerialOutput__ = 22;
const uint ZOOM3__AnalogSerialOutput__ = 23;
const uint RED4__AnalogSerialOutput__ = 24;
const uint GREEN4__AnalogSerialOutput__ = 25;
const uint BLUE4__AnalogSerialOutput__ = 26;
const uint WHITE4__AnalogSerialOutput__ = 27;
const uint DIM4__AnalogSerialOutput__ = 28;
const uint ZOOM4__AnalogSerialOutput__ = 29;
const uint RED5__AnalogSerialOutput__ = 30;
const uint GREEN5__AnalogSerialOutput__ = 31;
const uint BLUE5__AnalogSerialOutput__ = 32;
const uint WHITE5__AnalogSerialOutput__ = 33;
const uint DIM5__AnalogSerialOutput__ = 34;
const uint ZOOM5__AnalogSerialOutput__ = 35;
const uint RED6__AnalogSerialOutput__ = 36;
const uint GREEN6__AnalogSerialOutput__ = 37;
const uint BLUE6__AnalogSerialOutput__ = 38;
const uint WHITE6__AnalogSerialOutput__ = 39;
const uint DIM6__AnalogSerialOutput__ = 40;
const uint ZOOM6__AnalogSerialOutput__ = 41;
const uint RED7__AnalogSerialOutput__ = 42;
const uint GREEN7__AnalogSerialOutput__ = 43;
const uint BLUE7__AnalogSerialOutput__ = 44;
const uint WHITE7__AnalogSerialOutput__ = 45;
const uint DIM7__AnalogSerialOutput__ = 46;
const uint ZOOM7__AnalogSerialOutput__ = 47;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
