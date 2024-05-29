
# react-native-cook-trivia-helper

## Getting started

`$ npm install react-native-cook-trivia-helper --save`

### Mostly automatic installation

`$ react-native link react-native-cook-trivia-helper`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-cook-trivia-helper` and add `RNCookTriviaHelper.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNCookTriviaHelper.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNCookTriviaHelperPackage;` to the imports at the top of the file
  - Add `new RNCookTriviaHelperPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-cook-trivia-helper'
  	project(':react-native-cook-trivia-helper').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-cook-trivia-helper/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-cook-trivia-helper')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNCookTriviaHelper.sln` in `node_modules/react-native-cook-trivia-helper/windows/RNCookTriviaHelper.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Cook.Trivia.Helper.RNCookTriviaHelper;` to the usings at the top of the file
  - Add `new RNCookTriviaHelperPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNCookTriviaHelper from 'react-native-cook-trivia-helper';

// TODO: What to do with the module?
RNCookTriviaHelper;
```
  