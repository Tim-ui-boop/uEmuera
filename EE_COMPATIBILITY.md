# EE compatibility roadmap

This file tracks Emuera Anchor/EE functionality that is not yet available in uEmuera.

## Not implemented

- Sound-related functions and sound playback.
- XML resource loading.
- `CLEARMEMORY()`.
- `GETMEMORYUSAGE()`.
- `TRYCALLF`.

## Compatibility policy

Until an item is implemented and tested in a Unity Android build, games using it should be treated as incompatible. A future implementation should:

1. Register the function in the interpreter's function identifier table.
2. Validate its arguments using the existing argument builders.
3. Produce the same result and error behavior as the corresponding Emuera/Anchor implementation where possible.
4. Provide an Android-safe fallback for platform-specific functionality.
5. Add a small test game or script that exercises the function.

`GETMEMORYUSAGE()` and `CLEARMEMORY()` need special care because Unity's managed memory is not identical to the desktop Emuera process. `TRYCALLF` also needs to preserve the interpreter's existing TRY/CATCH state behavior rather than simply calling `CALLF`.
