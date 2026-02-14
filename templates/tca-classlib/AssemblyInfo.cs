// TODO: Add copyright file header here

using static TheCleanArch.Core.ArchLayerId;

#if (LayerIsEnterprise)
[assembly: ArchLayer(Enterprise, nameof(Enterprise))]
#elif (LayerIsApplication)
[assembly: ArchLayer(Application, nameof(Application))]
#elif (LayerIsInterfaceAdapter)
[assembly: ArchLayer(InterfaceAdapter, nameof(InterfaceAdapter))]
#elif (LayerIsExternal)
[assembly: ArchLayer(External, nameof(External))]
#endif
