# Loading busy indicator in DropDownFooterView

In SfComboBox, you can add the SfBusyIndicator when the data is being loaded with the help of DropDownHeaderView or DropDownFooterView. In the following example, the SfBusyIndicator has been loaded in the DropDownFooterView until the data is fetched.

**[XAML]**
```
     <StackLayout Padding="10">
        <Label Text="ComboBox"/>
        <comboBox:SfComboBox x:Name="comboBox"
                             HeightRequest="45"
                             IsEditableMode="True"
                             SuggestionMode="Contains"
                             MaximumDropDownHeight="150"
                             ShowDropDownFooterView="True"
                             DropDownFooterViewHeight="60"
                             ValueChanged="comboBox_ValueChanged"
                             NoResultsFoundText="No Results" 
                             AllowFiltering="True"
                             DisplayMemberPath="Name">
 
            <comboBox:SfComboBox.DropDownFooterView>
                <Grid VerticalOptions="StartAndExpand"
                      HeightRequest="60"
                      BackgroundColor="#f0f0f0" >
                    <busyIndicator:SfBusyIndicator VerticalOptions="Start"
                                                   x:Name="busyindicator"
                                                   AnimationType="SlicedCircle"
                                                   ViewBoxWidth = "40"
                                                   ViewBoxHeight="40"
                                                   TextColor="Maroon"
                                                   IsBusy="True"/>
                </Grid>
            </comboBox:SfComboBox.DropDownFooterView>
 
        </comboBox:SfComboBox>
    </StackLayout>
```
**[C#]**
```
private async void DataChanged()
{
     await Task.Delay(4000);
     busyindicator.IsBusy = false;
     comboBox.DropDownFooterViewHeight = 0;
     if (comboBox.DataSource == null)
     {
        LoadItems();
     }
}
private void comboBox_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
{
     DataChanged();
}
```
## How to run this application?

To run this application, you need to first clone the Load-BusyIndicator-in-DropDownFooterView repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.