
# react-native-dancer-fans-gz-activity

## Getting started

`$ npm install react-native-dancer-fans-gz-activity --save`

### Mostly automatic installation

`$ react-native link react-native-dancer-fans-gz-activity`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-dancer-fans-gz-activity` and add `RNDancerFansGzActivity.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNDancerFansGzActivity.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNDancerFansGzActivityPackage;` to the imports at the top of the file
  - Add `new RNDancerFansGzActivityPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-dancer-fans-gz-activity'
  	project(':react-native-dancer-fans-gz-activity').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-dancer-fans-gz-activity/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-dancer-fans-gz-activity')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNDancerFansGzActivity.sln` in `node_modules/react-native-dancer-fans-gz-activity/windows/RNDancerFansGzActivity.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Dancer.Fans.Gz.Activity.RNDancerFansGzActivity;` to the usings at the top of the file
  - Add `new RNDancerFansGzActivityPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNDancerFansGzActivity from 'react-native-dancer-fans-gz-activity';

// TODO: What to do with the module?
RNDancerFansGzActivity;
```
  