# The Kata Repo

The idea here is pretty simple.
Deliberate practice of skills as an engineer.
Build the same thing over, and over to practice my tools.

Because of this it's actually quite difficult to make the repository an easy way to evaluate my skills. Because of that I'm adopting a few conventions right away to make this easier to follow.
The directory tree always contains the following:
- `kata.md` the Kata statement, and any modifications I am making. This will say what language, tools, and so on, this kata uses.
- `readme.md` this file, explains how to see something useful out of this.
- `kata-records\` I plan to start recording various stats in here. Probably as commit hooks. There may, or may not be something interesting in here for each kata run. 

Branch orginization is as follows. `master/HEAD` is the EndPoint of my latest kata repitition. `{kata}/{language}/{count}` is a kata run. When a run is done the branch is left alive, and a squashed merge of it's outcome is plopped onto master. `base` holds a blank repo it is easy to branch from to create a new run. (similarly for `{kata}/base` and so on)

## TODO:

- [ ] Commit-hooks to update readme with kata info and run stats.
- [ ] Gather per-commit stats
- [ ] Something to make it easy for someone to fork and create their own base kata setup.
