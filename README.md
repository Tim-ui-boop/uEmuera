# uEmuera

uEmuera is a Unity port of the Emuera interpreter for playing era games on mobile platforms.

## Android game installation

Game files must be UTF-8 encoded. Place each era game in its own folder below one of these locations:

- `/storage/emulated/0/emuera`
- `/storage/emulated/1/emuera`
- `/storage/emulated/2/emuera`

On first launch, Android may ask for permission to access files. Grant that permission so uEmuera can discover and read games. The app also checks the legacy `sdcard0`, `sdcard1`, and `sdcard2` paths on devices that expose them.

## Compatibility limitations

uEmuera does not include all Emuera Anchor or EE functionality. A game can therefore contain untranslated text or fail to load when it depends on features that are not implemented by this port.

The following feature groups are currently unsupported or incomplete:

- Sound-related EE functions.
- XML resource loading.
- `CLEARMEMORY()`.
- `GETMEMORYUSAGE()`.
- `TRYCALLF`.
- Some other Anchor-only or EE-only functions.

Games using these functions may need to be modified before they can run. Unsupported functions must not be silently assumed to work; compatibility work should add an explicit implementation or a clear diagnostic before claiming support.

## Building

The project uses Unity. The Unity editor version recorded by the project is `6000.0.19f1`. Android APK builds should use that editor version, or a compatible Unity 6 version.

## License

See [LICENSE](LICENSE).
