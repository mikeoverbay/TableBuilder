# TableBuilder
Used to create a xml used for pkg file loook up.
It finds and add these files:
dds
primitive
visual
model
atlas

It also stores in that <items> entry, the package files name.
You can load the XML in to a datatable (VB or C#)and use LINQ to fine the package file a is located in.

This app will be intergrated in to nuTerra to speed up finding files.