# Contributing to Aro-Ace

First of all, thank you for contributing to this theme!
If you want to contribute please consider following guidelines.

## Color Palette

### Aro-Ace Flag Colors

| Hex Code  | Preview |
|:---------:|:-------:|
| #E28C00   | ![E28C00](images/swatches/E28C00.svg) |
| #ECCD00   | ![ECCD00](images/swatches/ECCD00.svg) |
| #FFFFFF   | ![FFFFFF](images/swatches/FFFFFF.svg) |
| #62AEDC   | ![62AEDC](images/swatches/62AEDC.svg) |
| #203856   | ![203856](images/swatches/203856.svg) |

### Aromantic Flag Colors

| Hex Code  | Preview |
|:---------:|:-------:|
| #3DA542   | ![3DA542](images/swatches/3DA542.svg) |
| #A6D378   | ![A6D378](images/swatches/A6D378.svg) |
| #FFFFFF   | ![FFFFFF](images/swatches/FFFFFF.svg) |
| #A8A8A8   | ![A8A8A8](images/swatches/A8A8A8.svg) |
| #000000   | ![000000](images/swatches/000000.svg) |

### Asexual Flag Colors

| Hex Code  | Preview |
|:---------:|:-------:|
| #000000   | ![000000](images/swatches/000000.svg) |
| #A3A3A3   | ![A3A3A3](images/swatches/A3A3A3.svg) |
| #FFFFFF   | ![FFFFFF](images/swatches/FFFFFF.svg) |
| #800080   | ![800080](images/swatches/800080.svg) |

## Contribution Guidelines

- New variants should incorporate the Aro-Ace flag colors.
- Theme files are located in the `themes/` folder.
- Please provide a short description of your changes in the pull request.

### How to add a new theme variant

1. **Create your theme file:**
	- Copy one of the existing theme JSON files in the `themes/` folder (e.g., `AroAce-color-theme.json`).
	- Rename your copy to something meaningful (e.g., `AroAceMyVariant-color-theme.json`).
	- Adjust the colors and settings as desired, using the Aro-Ace palette as a base.

2. **Register your theme in `package.json`:**
	- Open `package.json` and find the `contributes.themes` array.
	- Add a new object for your theme, for example:
	  ```json
	  {
		 "label": "Aro Ace My Variant",
		 "uiTheme": "vs-dark", // or "vs" for light, "hc-black" for high contrast
		 "path": "./themes/AroAceMyVariant-color-theme.json"
	  }
	  ```

3. **Test your theme:**
	- Press `F5` in VS Code to open a new Extension Development Host window.
	- Select your new theme in the Command Palette (`Ctrl+Shift+P` → "Color Theme").
	- Check that all colors and tokens appear as intended.

4. **Submit your changes:**
	- Commit your new theme file and the updated `package.json`.
	- Open a pull request with a short description of your variant and its purpose.
    - Optional: Update the CHANGELOG.md to include your new theme.

**Tip:**
You can add a preview image of your theme to the `images/` folder and reference it in your pull request or the README.

**Thank you for contributing to Aro-Ace! 🧡💛🤍🩵💙**
