# tureng-cli

Translating word between turkish and english by using [tureng.com](tureng.com), maybe in other languages too. I did not develop yet.

``lang`` is default command to run. There is no other parameter except help ``--h``

Just type what you want to translate. You can see examples below.

<img src="https://github.com/melihhtasci/language-cli/blob/main/doc_images/help.png?raw=true" />
<br/>

<img src="https://github.com/melihhtasci/language-cli/blob/main/doc_images/lang-1.png?raw=true" />
<br/>

<img src="https://github.com/melihhtasci/language-cli/blob/main/doc_images/lang-2.png?raw=true" />
<br/>

<img src="https://github.com/melihhtasci/language-cli/blob/main/doc_images/lang-3.png?raw=true" />
<br/>

<img src="https://github.com/melihhtasci/language-cli/blob/main/doc_images/lang-4.png?raw=true" />
<br/>
<br/>

### Packing

1. Edit project file and add these lines into PropertyGroup tag.
```
<PackAsTool>true</PackAsTool>
<ToolCommandName>lang</ToolCommandName>
<PackageOutputPath>./nupkg</PackageOutputPath>
```
2. run ``dotnet pack``
2. run ``dotnet tool install --global --add-source ./nupkg language-cli`` 

### Using resources
<hr>

1. <b>McMaster.Extensions.CommandLineUtils</b>
2. <b>HtmlAgilityPack</b>
3. <b>[tureng.com](https://tureng.com)</b>

