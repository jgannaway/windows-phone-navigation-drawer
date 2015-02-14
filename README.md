(ported to Windows Phone 8.0 from https://github.com/amarmesic/windows-phone-navigation-drawer)

Navigation Drawer Layout for Windows Phone 8.0 
==============================================

'One Drive like' Navigation Drawer Layout for Windows Phone 8.0.

![Navigation Drawer](http://amarmesic.net/img/navdrawer.gif)

How to Use
----

* Clone (download) the project

* Add the project (or just the .cs file) to your existing solution

* Add reference in your Windows Phone project

* In your MainPage.xaml, add a namespace
```sh
 xmlns:drawerLayout="clr-namespace:DrawerLayout;assembly=DrawerLayout"
```

* Replace the root Grid layout with the DrawerLayout

* Create two child Grid controls inside the DrawerLayout. First control will contain the main content and the second will contain the navigation drawer. Your MainPage.xaml code should look like this:

```sh
  <drawerLayout:DrawerLayout x:Name="DrawerLayout">
        <Grid>
            <!-- Main content goes here -->
        </Grid>
        <Grid>
            <!-- Navigation Drwawer goes here -->
        </Grid>
    </drawerLayout:DrawerLayout>
```

The final step is to initialize the layout in your MainPage constructor:

```sh
 public MainPage()
        {
            this.InitializeComponent();
            DrawerLayout.InitializeDrawerLayout();
        }
```

Documentation
--------------

### 1. Properties

* IsDrawerOpened - returns true if drawer opened, else returns false.

### 2. Methods

* InitializeDrawerLayout - initializes the drawer layout. Method must be called inside constructor.

* OpenDrawer - opens the navigation drawer.

* CloseDrawer - closes the navigation drawer.

### 3. Events
Drawer Layout raises two (self explanatory) events:

1. DrawerOpened - raised when you swipe the drawer to the right or call OpenDrawer.

2. DrawerClosed - raises when you swipe the drawer to the left or call CloseDrawer.

Licence
----

[http://opensource.org/licenses/MIT](http://opensource.org/licenses/MIT "MIT Licence")

