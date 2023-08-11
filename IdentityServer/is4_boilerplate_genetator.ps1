# Run this script to autogenerate the IdentityServer4 boilerplate code from the original git repository
# If you have problems runnign this script, run in powershell admin mode: Set-ExecutionPolicy RemoteSigned
# And then: .\is4_boilerplate_genetator.ps1

iex ((New-Object System.Net.WebClient).DownloadString('https://raw.githubusercontent.com/IdentityServer/IdentityServer4.Quickstart.UI/main/getmain.ps1'))
