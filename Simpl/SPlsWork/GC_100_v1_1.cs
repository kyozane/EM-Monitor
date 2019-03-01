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

namespace UserModule_GC_100_V1_1
{
    public class UserModuleClass_GC_100_V1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.StringInput GC_100_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput GET_CONFIG_P;
        Crestron.Logos.SplusObjects.DigitalInput VERSION_P;
        Crestron.Logos.SplusObjects.DigitalInput POLL_P;
        Crestron.Logos.SplusObjects.AnalogInput MODEL__POUND__;
        Crestron.Logos.SplusObjects.AnalogInput MODULE_POLL__POUND__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> RELAY;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> STOPIR_P;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> IR_OUT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput GC_100_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESPONSE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput VERSION__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput ERROR__POUND__;
        Crestron.Logos.SplusObjects.AnalogOutput MODULE__POUND__;
        Crestron.Logos.SplusObjects.AnalogOutput CONNECTOR__POUND__;
        Crestron.Logos.SplusObjects.AnalogOutput ID_SENT__POUND__;
        Crestron.Logos.SplusObjects.AnalogOutput ID_RETURNED__POUND__;
        Crestron.Logos.SplusObjects.DigitalOutput STATE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> RELAY_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DIGITAL_IN_FB;
        object GET_CONFIG_P_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 268;
                GC_100_TX__DOLLAR__  .UpdateValue ( "getdevices" + _SplusNVRAM.CR__DOLLAR__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object VERSION_P_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 273;
            ERROR__POUND__  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 275;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MODEL__POUND__  .UshortValue == 6))  ) ) 
                { 
                __context__.SourceCodeLine = 277;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MODULE_POLL__POUND__  .UshortValue > 3 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 279;
                    ERROR__POUND__  .Value = (ushort) ( 5 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 284;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( MODULE_POLL__POUND__  .UshortValue < 1 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( MODULE_POLL__POUND__  .UshortValue > 5 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 286;
                    ERROR__POUND__  .Value = (ushort) ( 5 ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 289;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ERROR__POUND__  .Value == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 291;
                GC_100_TX__DOLLAR__  .UpdateValue ( "version" + "," + Functions.ItoA (  (int) ( MODULE_POLL__POUND__  .UshortValue ) ) + _SplusNVRAM.CR__DOLLAR__  ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object POLL_P_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 297;
        ERROR__POUND__  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 299;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MODEL__POUND__  .UshortValue == 6))  ) ) 
            { 
            __context__.SourceCodeLine = 301;
            _SplusNVRAM.MODULE = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 302;
            _SplusNVRAM.CONNECTOR = (ushort) ( MODULE_POLL__POUND__  .UshortValue ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 304;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MODEL__POUND__  .UshortValue > 6 ))  ) ) 
                { 
                __context__.SourceCodeLine = 306;
                _SplusNVRAM.MODULE = (ushort) ( (4 + ((MODULE_POLL__POUND__  .UshortValue - 1) / 3)) ) ; 
                __context__.SourceCodeLine = 307;
                _SplusNVRAM.CONNECTOR = (ushort) ( Mod( MODULE_POLL__POUND__  .UshortValue , 3 ) ) ; 
                __context__.SourceCodeLine = 308;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.CONNECTOR == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 310;
                    _SplusNVRAM.CONNECTOR = (ushort) ( 3 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 315;
                ERROR__POUND__  .Value = (ushort) ( 6 ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 317;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ERROR__POUND__  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 319;
            GC_100_TX__DOLLAR__  .UpdateValue ( "getstate" + "," + Functions.ItoA (  (int) ( _SplusNVRAM.MODULE ) ) + ":" + Functions.ItoA (  (int) ( _SplusNVRAM.CONNECTOR ) ) + _SplusNVRAM.CR__DOLLAR__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOPIR_P_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 325;
        _SplusNVRAM.INPUT = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 326;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MODEL__POUND__  .UshortValue == 6))  ) ) 
            { 
            __context__.SourceCodeLine = 328;
            _SplusNVRAM.MODULE = (ushort) ( 2 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 330;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MODEL__POUND__  .UshortValue > 6 ))  ) ) 
                { 
                __context__.SourceCodeLine = 332;
                _SplusNVRAM.MODULE = (ushort) ( (4 + ((_SplusNVRAM.INPUT - 1) / 3)) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 336;
                ERROR__POUND__  .Value = (ushort) ( 7 ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 338;
        _SplusNVRAM.CONNECTOR = (ushort) ( Mod( _SplusNVRAM.INPUT , 3 ) ) ; 
        __context__.SourceCodeLine = 339;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.CONNECTOR == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 341;
            _SplusNVRAM.CONNECTOR = (ushort) ( 3 ) ; 
            } 
        
        __context__.SourceCodeLine = 343;
        GC_100_TX__DOLLAR__  .UpdateValue ( "stopir," + Functions.ItoA (  (int) ( _SplusNVRAM.MODULE ) ) + ":" + Functions.ItoA (  (int) ( _SplusNVRAM.CONNECTOR ) ) + _SplusNVRAM.CR__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RELAY_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 348;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MODEL__POUND__  .UshortValue > 6 ))  ) ) 
            { 
            __context__.SourceCodeLine = 350;
            _SplusNVRAM.INPUT = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 351;
            _SplusNVRAM.MODULE = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 352;
            _SplusNVRAM.CONNECTOR = (ushort) ( _SplusNVRAM.INPUT ) ; 
            __context__.SourceCodeLine = 353;
            _SplusNVRAM.TEMP__DOLLAR__  .UpdateValue ( "setstate," + Functions.ItoA (  (int) ( _SplusNVRAM.MODULE ) ) + ":" + Functions.ItoA (  (int) ( _SplusNVRAM.CONNECTOR ) ) + ",1" + _SplusNVRAM.CR__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 354;
            GC_100_TX__DOLLAR__  .UpdateValue ( _SplusNVRAM.TEMP__DOLLAR__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 358;
            ERROR__POUND__  .Value = (ushort) ( 8 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RELAY_OnRelease_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 365;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MODEL__POUND__  .UshortValue > 6 ))  ) ) 
            { 
            __context__.SourceCodeLine = 367;
            _SplusNVRAM.INPUT = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 368;
            _SplusNVRAM.MODULE = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 369;
            _SplusNVRAM.CONNECTOR = (ushort) ( _SplusNVRAM.INPUT ) ; 
            __context__.SourceCodeLine = 370;
            _SplusNVRAM.TEMP__DOLLAR__  .UpdateValue ( "setstate," + Functions.ItoA (  (int) ( _SplusNVRAM.MODULE ) ) + ":" + Functions.ItoA (  (int) ( _SplusNVRAM.CONNECTOR ) ) + ",0" + _SplusNVRAM.CR__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 371;
            GC_100_TX__DOLLAR__  .UpdateValue ( _SplusNVRAM.TEMP__DOLLAR__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 375;
            ERROR__POUND__  .Value = (ushort) ( 8 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IR_OUT__DOLLAR___OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 382;
        _SplusNVRAM.INPUT = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 383;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MODEL__POUND__  .UshortValue == 6))  ) ) 
            { 
            __context__.SourceCodeLine = 385;
            _SplusNVRAM.MODULE = (ushort) ( 2 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 387;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MODEL__POUND__  .UshortValue > 6 ))  ) ) 
                { 
                __context__.SourceCodeLine = 389;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.INPUT > 3 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 391;
                    _SplusNVRAM.MODULE = (ushort) ( 5 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 395;
                    _SplusNVRAM.MODULE = (ushort) ( 4 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 400;
                ERROR__POUND__  .Value = (ushort) ( 9 ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 402;
        _SplusNVRAM.CONNECTOR = (ushort) ( Mod( _SplusNVRAM.INPUT , 3 ) ) ; 
        __context__.SourceCodeLine = 403;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.CONNECTOR == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 405;
            _SplusNVRAM.CONNECTOR = (ushort) ( 3 ) ; 
            } 
        
        __context__.SourceCodeLine = 408;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ERROR__POUND__  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 410;
            _SplusNVRAM.TEMP__DOLLAR__  .UpdateValue ( "sendir," + Functions.ItoA (  (int) ( _SplusNVRAM.MODULE ) ) + ":" + Functions.ItoA (  (int) ( _SplusNVRAM.CONNECTOR ) ) + "," + Functions.ItoA (  (int) ( _SplusNVRAM.ID ) )  ) ; 
            __context__.SourceCodeLine = 411;
            _SplusNVRAM.ICMDLEN = (ushort) ( Functions.Length( IR_OUT__DOLLAR__[ _SplusNVRAM.INPUT ] ) ) ; 
            __context__.SourceCodeLine = 412;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.ICMDLEN < 225 ))  ) ) 
                { 
                __context__.SourceCodeLine = 414;
                GC_100_TX__DOLLAR__  .UpdateValue ( _SplusNVRAM.TEMP__DOLLAR__ + "," + IR_OUT__DOLLAR__ [ _SplusNVRAM.INPUT ] + _SplusNVRAM.CR__DOLLAR__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 417;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)_SplusNVRAM.ICMDLEN; 
                int __FN_FORSTEP_VAL__1 = (int)225; 
                for ( _SplusNVRAM.X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_SplusNVRAM.X  >= __FN_FORSTART_VAL__1) && (_SplusNVRAM.X  <= __FN_FOREND_VAL__1) ) : ( (_SplusNVRAM.X  <= __FN_FORSTART_VAL__1) && (_SplusNVRAM.X  >= __FN_FOREND_VAL__1) ) ; _SplusNVRAM.X  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 419;
                    Functions.ProcessLogic ( ) ; 
                    __context__.SourceCodeLine = 420;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.X == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 422;
                        GC_100_TX__DOLLAR__  .UpdateValue ( _SplusNVRAM.TEMP__DOLLAR__ + "," + Functions.Mid ( IR_OUT__DOLLAR__ [ _SplusNVRAM.INPUT ] ,  (int) ( _SplusNVRAM.X ) ,  (int) ( 225 ) )  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 425;
                        GC_100_TX__DOLLAR__  .UpdateValue ( Functions.Mid ( IR_OUT__DOLLAR__ [ _SplusNVRAM.INPUT ] ,  (int) ( _SplusNVRAM.X ) ,  (int) ( 225 ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 417;
                    } 
                
                __context__.SourceCodeLine = 428;
                GC_100_TX__DOLLAR__  .UpdateValue ( _SplusNVRAM.CR__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 429;
                Functions.ProcessLogic ( ) ; 
                } 
            
            __context__.SourceCodeLine = 432;
            ID_SENT__POUND__  .Value = (ushort) ( _SplusNVRAM.ID ) ; 
            __context__.SourceCodeLine = 433;
            _SplusNVRAM.ID = (ushort) ( (_SplusNVRAM.ID + 1) ) ; 
            __context__.SourceCodeLine = 434;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ID == 65534))  ) ) 
                { 
                __context__.SourceCodeLine = 436;
                _SplusNVRAM.ID = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GC_100_RX__DOLLAR___OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 445;
        _SplusNVRAM.TEMP_RESPONSE__DOLLAR__  .UpdateValue ( _SplusNVRAM.TEMP_RESPONSE__DOLLAR__ + GC_100_RX__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 446;
        _SplusNVRAM.TARGET__DOLLAR__  .UpdateValue ( " "  ) ; 
        __context__.SourceCodeLine = 447;
        while ( Functions.TestForTrue  ( ( Functions.Length( _SplusNVRAM.TARGET__DOLLAR__ ))  ) ) 
            { 
            __context__.SourceCodeLine = 449;
            ERROR__POUND__  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 450;
            STATE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 451;
            CONNECTOR__POUND__  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 452;
            MODULE__POUND__  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 453;
            _SplusNVRAM.COMMAND__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 454;
            RESPONSE__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 455;
            _SplusNVRAM.ADDRESS__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 456;
            _SplusNVRAM.MODULE__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 457;
            _SplusNVRAM.CONNECTOR__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 458;
            _SplusNVRAM.PARAM__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 459;
            _SplusNVRAM.TARGET__DOLLAR__  .UpdateValue ( Functions.Remove ( _SplusNVRAM.CR__DOLLAR__ , _SplusNVRAM.TEMP_RESPONSE__DOLLAR__ )  ) ; 
            __context__.SourceCodeLine = 460;
            if ( Functions.TestForTrue  ( ( Functions.Length( _SplusNVRAM.TARGET__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 462;
                _SplusNVRAM.COMMAND__DOLLAR__  .UpdateValue ( Functions.Remove ( _SplusNVRAM.COMMA__DOLLAR__ , _SplusNVRAM.TARGET__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 463;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _SplusNVRAM.COMMAND__DOLLAR__ ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 465;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "unknowncommand" , _SplusNVRAM.TARGET__DOLLAR__ , 1 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 467;
                        ERROR__POUND__  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 468;
                        ID_RETURNED__POUND__  .Value = (ushort) ( Functions.Atoi( Functions.Mid( _SplusNVRAM.TARGET__DOLLAR__ , (int)( 16 ) , (int)( (Functions.Length( _SplusNVRAM.TARGET__DOLLAR__ ) - 16) ) ) ) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 470;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "devicechange" , _SplusNVRAM.TARGET__DOLLAR__ , 1 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 472;
                            ERROR__POUND__  .Value = (ushort) ( 2 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 476;
                            ERROR__POUND__  .Value = (ushort) ( 4 ) ; 
                            } 
                        
                        }
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 481;
                    _SplusNVRAM.ADDRESS__DOLLAR__  .UpdateValue ( Functions.Remove ( _SplusNVRAM.COMMA__DOLLAR__ , _SplusNVRAM.TARGET__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 483;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _SplusNVRAM.ADDRESS__DOLLAR__ ) == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 485;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "serialoverflow" , _SplusNVRAM.COMMAND__DOLLAR__ ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 487;
                            ERROR__POUND__  .Value = (ushort) ( 3 ) ; 
                            __context__.SourceCodeLine = 488;
                            _SplusNVRAM.MODULE__DOLLAR__  .UpdateValue ( Functions.Remove ( _SplusNVRAM.CR__DOLLAR__ , _SplusNVRAM.TARGET__DOLLAR__ )  ) ; 
                            __context__.SourceCodeLine = 489;
                            MODULE__POUND__  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.MODULE__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.MODULE__DOLLAR__ ) - 1) ) ) ) ) ; 
                            __context__.SourceCodeLine = 490;
                            _SplusNVRAM.COMMAND__DOLLAR__  .UpdateValue ( ""  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 494;
                            ERROR__POUND__  .Value = (ushort) ( 4 ) ; 
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 499;
                        _SplusNVRAM.MODULE__DOLLAR__  .UpdateValue ( Functions.Remove ( _SplusNVRAM.COLON__DOLLAR__ , _SplusNVRAM.ADDRESS__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 500;
                        RESPONSE__DOLLAR__  .UpdateValue ( Functions.Left ( _SplusNVRAM.COMMAND__DOLLAR__ ,  (int) ( (Functions.Length( _SplusNVRAM.COMMAND__DOLLAR__ ) - 1) ) )  ) ; 
                        __context__.SourceCodeLine = 501;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( _SplusNVRAM.MODULE__DOLLAR__ ) == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 503;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "version" , _SplusNVRAM.COMMAND__DOLLAR__ , 1 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 505;
                                MODULE__POUND__  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.ADDRESS__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.ADDRESS__DOLLAR__ ) - 1) ) ) ) ) ; 
                                __context__.SourceCodeLine = 506;
                                VERSION__DOLLAR__  .UpdateValue ( Functions.Left ( _SplusNVRAM.TARGET__DOLLAR__ ,  (int) ( (Functions.Length( _SplusNVRAM.TARGET__DOLLAR__ ) - 1) ) )  ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 509;
                                ERROR__POUND__  .Value = (ushort) ( 4 ) ; 
                                __context__.SourceCodeLine = 510;
                                RESPONSE__DOLLAR__  .UpdateValue ( ""  ) ; 
                                } 
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 515;
                            MODULE__POUND__  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.MODULE__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.MODULE__DOLLAR__ ) - 1) ) ) ) ) ; 
                            __context__.SourceCodeLine = 516;
                            CONNECTOR__POUND__  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.ADDRESS__DOLLAR__ , (int)( Functions.Length( _SplusNVRAM.ADDRESS__DOLLAR__ ) ) ) ) ) ; 
                            __context__.SourceCodeLine = 517;
                            _SplusNVRAM.PARAM__DOLLAR__  .UpdateValue ( Functions.Remove ( _SplusNVRAM.CR__DOLLAR__ , _SplusNVRAM.TARGET__DOLLAR__ )  ) ; 
                            __context__.SourceCodeLine = 518;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "state," , _SplusNVRAM.COMMAND__DOLLAR__ , 1 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 520;
                                STATE  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.PARAM__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.PARAM__DOLLAR__ ) - 1) ) ) ) ) ; 
                                __context__.SourceCodeLine = 521;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MODEL__POUND__  .UshortValue == 6))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 523;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MODULE__POUND__  .Value == 2))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 525;
                                        _SplusNVRAM.INPUT = (ushort) ( CONNECTOR__POUND__  .Value ) ; 
                                        __context__.SourceCodeLine = 526;
                                        DIGITAL_IN_FB [ _SplusNVRAM.INPUT]  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.PARAM__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.PARAM__DOLLAR__ ) - 1) ) ) ) ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 529;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MODEL__POUND__  .UshortValue > 6 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 531;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MODULE__POUND__  .Value == 3))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 533;
                                            _SplusNVRAM.INPUT = (ushort) ( CONNECTOR__POUND__  .Value ) ; 
                                            __context__.SourceCodeLine = 534;
                                            RELAY_FB [ _SplusNVRAM.INPUT]  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.PARAM__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.PARAM__DOLLAR__ ) - 1) ) ) ) ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 536;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MODULE__POUND__  .Value > 3 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 538;
                                                _SplusNVRAM.INPUT = (ushort) ( (((MODULE__POUND__  .Value - 4) * 3) + CONNECTOR__POUND__  .Value) ) ; 
                                                __context__.SourceCodeLine = 539;
                                                DIGITAL_IN_FB [ _SplusNVRAM.INPUT]  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.PARAM__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.PARAM__DOLLAR__ ) - 1) ) ) ) ) ; 
                                                } 
                                            
                                            }
                                        
                                        } 
                                    
                                    }
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 544;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "device," , _SplusNVRAM.COMMAND__DOLLAR__ , 1 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 546;
                                    STATE  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.PARAM__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.PARAM__DOLLAR__ ) - 1) ) ) ) ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 548;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "statechange" , _SplusNVRAM.COMMAND__DOLLAR__ , 1 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 550;
                                        STATE  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.PARAM__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.PARAM__DOLLAR__ ) - 1) ) ) ) ) ; 
                                        __context__.SourceCodeLine = 551;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MODEL__POUND__  .UshortValue == 6))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 553;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MODULE__POUND__  .Value == 2))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 555;
                                                _SplusNVRAM.INPUT = (ushort) ( CONNECTOR__POUND__  .Value ) ; 
                                                __context__.SourceCodeLine = 556;
                                                DIGITAL_IN_FB [ _SplusNVRAM.INPUT]  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.PARAM__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.PARAM__DOLLAR__ ) - 1) ) ) ) ) ; 
                                                } 
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 559;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MODEL__POUND__  .UshortValue > 6 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 561;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MODULE__POUND__  .Value == 3))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 563;
                                                    _SplusNVRAM.INPUT = (ushort) ( CONNECTOR__POUND__  .Value ) ; 
                                                    __context__.SourceCodeLine = 564;
                                                    RELAY_FB [ _SplusNVRAM.INPUT]  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.PARAM__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.PARAM__DOLLAR__ ) - 1) ) ) ) ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 566;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MODULE__POUND__  .Value > 3 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 568;
                                                        _SplusNVRAM.INPUT = (ushort) ( (((MODULE__POUND__  .Value - 4) * 3) + CONNECTOR__POUND__  .Value) ) ; 
                                                        __context__.SourceCodeLine = 569;
                                                        DIGITAL_IN_FB [ _SplusNVRAM.INPUT]  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.PARAM__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.PARAM__DOLLAR__ ) - 1) ) ) ) ) ; 
                                                        } 
                                                    
                                                    }
                                                
                                                } 
                                            
                                            }
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 574;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "completeir" , _SplusNVRAM.COMMAND__DOLLAR__ , 1 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 576;
                                            ID_RETURNED__POUND__  .Value = (ushort) ( Functions.Atoi( Functions.Left( _SplusNVRAM.PARAM__DOLLAR__ , (int)( (Functions.Length( _SplusNVRAM.PARAM__DOLLAR__ ) - 1) ) ) ) ) ; 
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 580;
                                            ERROR__POUND__  .Value = (ushort) ( 4 ) ; 
                                            __context__.SourceCodeLine = 581;
                                            RESPONSE__DOLLAR__  .UpdateValue ( ""  ) ; 
                                            } 
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            } 
                        
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 447;
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
        
        __context__.SourceCodeLine = 613;
        _SplusNVRAM.CR__DOLLAR__  .UpdateValue ( Functions.Chr (  (int) ( 13 ) )  ) ; 
        __context__.SourceCodeLine = 614;
        _SplusNVRAM.COMMA__DOLLAR__  .UpdateValue ( ","  ) ; 
        __context__.SourceCodeLine = 615;
        _SplusNVRAM.COLON__DOLLAR__  .UpdateValue ( ":"  ) ; 
        __context__.SourceCodeLine = 616;
        _SplusNVRAM.ID = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 618;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
    _SplusNVRAM.CR__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    _SplusNVRAM.COLON__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    _SplusNVRAM.COMMA__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    _SplusNVRAM.TEMP_RESPONSE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.TARGET__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _SplusNVRAM.ADDRESS__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    _SplusNVRAM.MODULE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    _SplusNVRAM.CONNECTOR__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    _SplusNVRAM.COMMAND__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _SplusNVRAM.PARAM__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    
    GET_CONFIG_P = new Crestron.Logos.SplusObjects.DigitalInput( GET_CONFIG_P__DigitalInput__, this );
    m_DigitalInputList.Add( GET_CONFIG_P__DigitalInput__, GET_CONFIG_P );
    
    VERSION_P = new Crestron.Logos.SplusObjects.DigitalInput( VERSION_P__DigitalInput__, this );
    m_DigitalInputList.Add( VERSION_P__DigitalInput__, VERSION_P );
    
    POLL_P = new Crestron.Logos.SplusObjects.DigitalInput( POLL_P__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_P__DigitalInput__, POLL_P );
    
    RELAY = new InOutArray<DigitalInput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        RELAY[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( RELAY__DigitalInput__ + i, RELAY__DigitalInput__, this );
        m_DigitalInputList.Add( RELAY__DigitalInput__ + i, RELAY[i+1] );
    }
    
    STOPIR_P = new InOutArray<DigitalInput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        STOPIR_P[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( STOPIR_P__DigitalInput__ + i, STOPIR_P__DigitalInput__, this );
        m_DigitalInputList.Add( STOPIR_P__DigitalInput__ + i, STOPIR_P[i+1] );
    }
    
    STATE = new Crestron.Logos.SplusObjects.DigitalOutput( STATE__DigitalOutput__, this );
    m_DigitalOutputList.Add( STATE__DigitalOutput__, STATE );
    
    RELAY_FB = new InOutArray<DigitalOutput>( 3, this );
    for( uint i = 0; i < 3; i++ )
    {
        RELAY_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( RELAY_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( RELAY_FB__DigitalOutput__ + i, RELAY_FB[i+1] );
    }
    
    DIGITAL_IN_FB = new InOutArray<DigitalOutput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        DIGITAL_IN_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DIGITAL_IN_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( DIGITAL_IN_FB__DigitalOutput__ + i, DIGITAL_IN_FB[i+1] );
    }
    
    MODEL__POUND__ = new Crestron.Logos.SplusObjects.AnalogInput( MODEL__POUND____AnalogSerialInput__, this );
    m_AnalogInputList.Add( MODEL__POUND____AnalogSerialInput__, MODEL__POUND__ );
    
    MODULE_POLL__POUND__ = new Crestron.Logos.SplusObjects.AnalogInput( MODULE_POLL__POUND____AnalogSerialInput__, this );
    m_AnalogInputList.Add( MODULE_POLL__POUND____AnalogSerialInput__, MODULE_POLL__POUND__ );
    
    ERROR__POUND__ = new Crestron.Logos.SplusObjects.AnalogOutput( ERROR__POUND____AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ERROR__POUND____AnalogSerialOutput__, ERROR__POUND__ );
    
    MODULE__POUND__ = new Crestron.Logos.SplusObjects.AnalogOutput( MODULE__POUND____AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MODULE__POUND____AnalogSerialOutput__, MODULE__POUND__ );
    
    CONNECTOR__POUND__ = new Crestron.Logos.SplusObjects.AnalogOutput( CONNECTOR__POUND____AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONNECTOR__POUND____AnalogSerialOutput__, CONNECTOR__POUND__ );
    
    ID_SENT__POUND__ = new Crestron.Logos.SplusObjects.AnalogOutput( ID_SENT__POUND____AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ID_SENT__POUND____AnalogSerialOutput__, ID_SENT__POUND__ );
    
    ID_RETURNED__POUND__ = new Crestron.Logos.SplusObjects.AnalogOutput( ID_RETURNED__POUND____AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ID_RETURNED__POUND____AnalogSerialOutput__, ID_RETURNED__POUND__ );
    
    GC_100_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( GC_100_RX__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( GC_100_RX__DOLLAR____AnalogSerialInput__, GC_100_RX__DOLLAR__ );
    
    IR_OUT__DOLLAR__ = new InOutArray<StringInput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        IR_OUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( IR_OUT__DOLLAR____AnalogSerialInput__ + i, IR_OUT__DOLLAR____AnalogSerialInput__, 2048, this );
        m_StringInputList.Add( IR_OUT__DOLLAR____AnalogSerialInput__ + i, IR_OUT__DOLLAR__[i+1] );
    }
    
    GC_100_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( GC_100_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( GC_100_TX__DOLLAR____AnalogSerialOutput__, GC_100_TX__DOLLAR__ );
    
    RESPONSE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESPONSE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( RESPONSE__DOLLAR____AnalogSerialOutput__, RESPONSE__DOLLAR__ );
    
    VERSION__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( VERSION__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( VERSION__DOLLAR____AnalogSerialOutput__, VERSION__DOLLAR__ );
    
    
    GET_CONFIG_P.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_CONFIG_P_OnPush_0, false ) );
    VERSION_P.OnDigitalPush.Add( new InputChangeHandlerWrapper( VERSION_P_OnPush_1, false ) );
    POLL_P.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_P_OnPush_2, false ) );
    for( uint i = 0; i < 6; i++ )
        STOPIR_P[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( STOPIR_P_OnPush_3, false ) );
        
    for( uint i = 0; i < 3; i++ )
        RELAY[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( RELAY_OnPush_4, false ) );
        
    for( uint i = 0; i < 3; i++ )
        RELAY[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( RELAY_OnRelease_5, false ) );
        
    for( uint i = 0; i < 6; i++ )
        IR_OUT__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( IR_OUT__DOLLAR___OnChange_6, false ) );
        
    GC_100_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( GC_100_RX__DOLLAR___OnChange_7, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_GC_100_V1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint GC_100_RX__DOLLAR____AnalogSerialInput__ = 0;
const uint GET_CONFIG_P__DigitalInput__ = 0;
const uint VERSION_P__DigitalInput__ = 1;
const uint POLL_P__DigitalInput__ = 2;
const uint MODEL__POUND____AnalogSerialInput__ = 1;
const uint MODULE_POLL__POUND____AnalogSerialInput__ = 2;
const uint RELAY__DigitalInput__ = 3;
const uint STOPIR_P__DigitalInput__ = 6;
const uint IR_OUT__DOLLAR____AnalogSerialInput__ = 3;
const uint GC_100_TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint RESPONSE__DOLLAR____AnalogSerialOutput__ = 1;
const uint VERSION__DOLLAR____AnalogSerialOutput__ = 2;
const uint ERROR__POUND____AnalogSerialOutput__ = 3;
const uint MODULE__POUND____AnalogSerialOutput__ = 4;
const uint CONNECTOR__POUND____AnalogSerialOutput__ = 5;
const uint ID_SENT__POUND____AnalogSerialOutput__ = 6;
const uint ID_RETURNED__POUND____AnalogSerialOutput__ = 7;
const uint STATE__DigitalOutput__ = 0;
const uint RELAY_FB__DigitalOutput__ = 1;
const uint DIGITAL_IN_FB__DigitalOutput__ = 4;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort INPUT = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort MODULE = 0;
            [SplusStructAttribute(2, false, true)]
            public ushort CONNECTOR = 0;
            [SplusStructAttribute(3, false, true)]
            public ushort ID = 0;
            [SplusStructAttribute(4, false, true)]
            public ushort ICMDLEN = 0;
            [SplusStructAttribute(5, false, true)]
            public ushort X = 0;
            [SplusStructAttribute(6, false, true)]
            public CrestronString TEMP__DOLLAR__;
            [SplusStructAttribute(7, false, true)]
            public CrestronString CR__DOLLAR__;
            [SplusStructAttribute(8, false, true)]
            public CrestronString COLON__DOLLAR__;
            [SplusStructAttribute(9, false, true)]
            public CrestronString COMMA__DOLLAR__;
            [SplusStructAttribute(10, false, true)]
            public CrestronString TEMP_RESPONSE__DOLLAR__;
            [SplusStructAttribute(11, false, true)]
            public CrestronString TARGET__DOLLAR__;
            [SplusStructAttribute(12, false, true)]
            public CrestronString ADDRESS__DOLLAR__;
            [SplusStructAttribute(13, false, true)]
            public CrestronString MODULE__DOLLAR__;
            [SplusStructAttribute(14, false, true)]
            public CrestronString CONNECTOR__DOLLAR__;
            [SplusStructAttribute(15, false, true)]
            public CrestronString COMMAND__DOLLAR__;
            [SplusStructAttribute(16, false, true)]
            public CrestronString PARAM__DOLLAR__;
            
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
