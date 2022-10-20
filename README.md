# tureng-cli v1.2

Translating word between turkish and english, maybe in other languages too. I did not develop yet.

``lang`` is default command to run. There is no other parameter except help ``--h``

Just type what you want to translate. You can see examples below.

I added an optional parameter for meaning of english words 
by using **dictionaryapi.dev**. 
I tried some sentence pattern and couldnt get answer. 
So there is no problem if you cant get result.

<img src="https://github.com/melihhtasci/tureng-cli/blob/main/doc_images/help.png?raw=true" />
<br/>

<img src="https://github.com/melihhtasci/tureng-cli/blob/main/doc_images/lang-1.png?raw=true" />
<br/>

<img src="https://github.com/melihhtasci/tureng-cli/blob/main/doc_images/lang-2.png?raw=true" />
<br/>

<img src="https://github.com/melihhtasci/tureng-cli/blob/main/doc_images/lang-3.png?raw=true" />
<br/>

<img src="https://github.com/melihhtasci/tureng-cli/blob/main/doc_images/lang-4.png?raw=true" />
<br/>

<img src="https://github.com/melihhtasci/tureng-cli/blob/main/doc_images/d-parameter.png?raw=true" />
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
3. <b>[dictionaryapi.dev](https://api.dictionaryapi.dev/api/v2/entries/en/student)</b>

