# Sharpass

A little CLI tool to generate cryptographic strong password made for fun in 3 hours.

Supports NativeAOT compilation (and was made with it in mind).

### Algorithm???

This thing is fully opinionated, there are no specifications/recommendations/etc used

- 60-80% of password are `letters`
- 60-70% of `letters` are `lowercase_letters`
- `password_length - letters` are `nonLetters`
- 60-80% of `nonLetters` are `digits`
- `nonLetters - digits` are `special_characters`

### Command line arguments
- `-r, --russian` - use russian letters (lol)
- `-c, --count` - how many passwords do u want? huh?
- `-l, --length` - how long is your... password?
- You can get more detailed list without jokes by using `sharpass --help`

### Build
Instal dotnet SDK v8 and run `dotnet publish -c Release -r <RID>` where RID is short for Runtime IDentifier ([you can obtain one here](https://learn.microsoft.com/en-us/dotnet/core/rid-catalog#known-rids)). Probably, you need `win-x64` or `linux-x64`. 
