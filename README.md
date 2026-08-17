# git-submodules-lesson-lib

The tiny .NET class library used as the **submodule** (path `libs/shared-lib`) in the
45-minute hands-on lesson at https://github.com/tzaczek/git-submodules-lesson (see its LESSON.md).

Contents: `src/SharedLib/SharedLib.csproj` (net10.0 classlib) with one class, `Greeter`.

## History (frozen for the lesson)

| Ref | Meaning |
|---|---|
| `v1.0.0` (annotated tag) | `Greeter.Greet(name)` -> `Hello, {name}! (shared-lib 1.0.0)` |
| `v1.1.0` (annotated tag) | adds `Greeter.Version` and `Greeter.Farewell(name)`; `Greet` prints a second line `Goodbye, {name}!` |
| `main` | = `v1.1.0` at the start of the lesson |
| `lesson-start` (lightweight tag) | = `v1.1.0`; used only by the reset procedure |

`main` is only edited in Block 6 of the lesson (Bob's "Friendlier farewell" commit).
Do not push anything else here.

## Reset to the starting state

From a fresh clone (LESSON.md, Appendix B):

```powershell
git push --force https://github.com/tzaczek/git-submodules-lesson-lib.git refs/tags/lesson-start:refs/heads/main
```
