# Black Division

Adds the **Black Division** faction to SPT — a custom PMC-style faction with its own
loadouts, spawns, boss (Wedge), achievements and hunt events across Labs, Customs,
Streets, Shoreline and Woods. Built on top of MoreBotsAPI.

---

# 🟣 JOIN THE DISCORD — https://discord.gg/nxa3W7w4rJ

### **https://discord.gg/nxa3W7w4rJ**

**This is the single most important link in this README.** All updates, release
announcements, bug fixes, early builds and support happen in the Discord **first**.
If you run this mod, join it — it is the only place you will reliably hear about
breaking changes and new versions.

**What's coming next:** I am building a **post-1.0 patcher and backend, written
from scratch and engineered to be very performant** — a proper foundation instead
of the current patchwork. **All of these mods will shortly be merged into that new
system.** If you want to follow that work, or use it when it lands, the Discord is
where it will be announced.

### 👉 **https://discord.gg/nxa3W7w4rJ** 👈

---


## Requirements

This mod will **not load** without all of the following server mods installed:

| Dependency | Minimum version |
|---|---|
| [MoreBotsAPI](https://github.com/savannt/SPT-MoreBotsAPI) | 2.0.0 |
| WTT-ServerCommonLib | 2.0.0 |
| WTT-ContentBackport | 1.0.0 |

**Requires SPT 4.1.2.**

## Installation

1. Install the three dependencies above first.
2. Download the latest release zip from GitHub.
3. Extract it into your **SPT install root** — the folder containing `EscapeFromTarkov.exe` and `SPT_Runtime`.

The zip is already laid out correctly and will place:

```
BepInEx/patchers/BlackDivPrepatch.dll        <- client prepatcher
BepInEx/plugins/BlackDiv/BlackDiv.dll        <- client plugin
SPT_Runtime/user/mods/BlackDivServer/        <- server mod (DLL + db/ + config.jsonc)
```

> **Note:** the prepatcher **must** end up in `BepInEx/patchers/`, not `BepInEx/plugins/`, or it will never run.
> Server mods live under `SPT_Runtime/user/mods/` — **not** `user/mods/` at the SPT root. A server mod folder
> placed at the root is silently ignored by the server.

## Configuration

Edit `SPT_Runtime/user/mods/BlackDivServer/config.jsonc` to tune spawn rates, hunt
sizes and which maps the faction appears on.

## Troubleshooting

**"Exception occured while loading a mod at path: ./user/mods/..."** — you are almost
certainly running a mismatched build of one of the dependencies. Make sure MoreBotsAPI
is the 2.0.3+ release from the link above, and that every mod came from an SPT 4.1.2
release. Mixing a server DLL built for a different SPT version produces
`Could not load type ... AbstractModMetadata` or `Method OnLoadAsync ... does not have
an implementation`.

**A mod folder is ignored entirely** — check it is in `SPT_Runtime/user/mods/`, not
`user/mods/`.

## License

MIT — see [LICENSE](LICENSE).
