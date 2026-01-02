using System;

namespace Celeste.Mod.ElegiacHelper;

public class ElegiacHelperModule : EverestModule {
    public static ElegiacHelperModule Instance { get; private set; }

    public override Type SettingsType => typeof(ElegiacHelperModuleSettings);
    public static ElegiacHelperModuleSettings Settings => (ElegiacHelperModuleSettings) Instance._Settings;

    public override Type SessionType => typeof(ElegiacHelperModuleSession);
    public static ElegiacHelperModuleSession Session => (ElegiacHelperModuleSession) Instance._Session;

    public override Type SaveDataType => typeof(ElegiacHelperModuleSaveData);
    public static ElegiacHelperModuleSaveData SaveData => (ElegiacHelperModuleSaveData) Instance._SaveData;

    public ElegiacHelperModule() {
        Instance = this;
#if DEBUG
        // debug builds use verbose logging
        Logger.SetLogLevel(nameof(ElegiacHelperModule), LogLevel.Verbose);
#else
        // release builds use info logging to reduce spam in log files
        Logger.SetLogLevel(nameof(ElegiacHelperModule), LogLevel.Info);
#endif
    }

    public override void Load() {
        // TODO: apply any hooks that should always be active
    }

    public override void Unload() {
        // TODO: unapply any hooks applied in Load()
    }
}