# MiniExplorer

**MiniExplorer** egy egyszerű fájlkezelő alkalmazás, amely lehetővé teszi a fájlok megnyitását, megtekintését és alapvető szerkesztését.

## Fő Funkciók

### 1. **Fájlok megnyitása**
- A **File** menü legördülő listájában található **Open** menüpont segítségével nyithatóak meg fájlok.
- A kattintás után egy felugró **dialógusablak** jelenik meg, ahol egy **szövegdobozba** írhatja be a fájl elérési útvonalát.

### 2. **Fájllista megjelenítése**
- Az elérési útvonal megadása után a főablak bal oldali listáján megjelennek a megnyitott fájlok.
- A listában a fájlok neve és mérete (byte-ban) is látható.

### 3. **Fájl megnyitása és tartalom megjelenítése**
- Dupla kattintással egy fájl nevére:
  - A fájl tartalma megjelenik a főablak jobb oldali **szövegdobozában**.
  - A fejlécben láthatóvá válik a fájl **készítési dátuma**.

### 4. **Fájl tartalmának módosítása**
- A fájl tartalma a szövegdobozban módosítható.
- A szövegdoboz automatikusan **6 másodpercenként frissíti** magát, és betölti a fájl aktuális tartalmát, hogy mindig a legfrissebb információ jelenjen meg.

## Rendszerkövetelmények
- **Operációs rendszer:** Windows
- **Programozási nyelv:** C# (Windows Forms)

## Használati Útmutató
1. Indítsd el az alkalmazást.
2. A **File > Open** menüpont segítségével nyiss meg egy fájlt az elérési útvonal megadásával.
3. Nézd meg a fájlok listáját a bal oldalon, ahol a fájl neve és mérete látható.
4. Dupla kattintással nyiss meg egy fájlt, hogy annak tartalmát láthasd és szerkeszthesd.
5. A módosított fájl tartalma automatikusan frissül 6 másodpercenként.

# Fileok

## InputDialog
Ez a Form egy egyszerű **InputDialog** osztályt valósít meg a Windows Forms alkalmazáshoz, amely felhasználható elérési útvonalak bevitelére és kezelésére.

### Főbb jellemzők
- **Felugró párbeszédablak:** Egy szövegdobozzal (`tPath`), amelyben a felhasználó megadhatja az elérési útvonalat.
- **Elérési út kezelése:** Az `InputDialog` osztály tartalmaz egy `Path` nevű tulajdonságot, amely segítségével beállítható vagy lekérdezhető a szövegdoboz tartalma.

## MainForm

A főablak lehetőséget biztosít fájlok megnyitására, listázására és azok tartalmának megtekintésére.  

### **Fontos metódusok**  

1. **ListViewerGetFiles(string result)**  
   - A megadott könyvtárban található fájlokat listázza ki a ListView vezérlőben.  

2. **miOpen_Click(object sender, EventArgs e)**  
   - Egy **InputDialog** segítségével lehetőséget ad az elérési útvonal megadására, majd meghívja a fájllistázó metódust.  

3. **listView1_SelectedIndexChanged(object sender, EventArgs e)**  
   - A kiválasztott fájl nevét és létrehozási dátumát jeleníti meg.  

4. **listView1_MouseDoubleClick(object sender, MouseEventArgs e)**  
   - Dupla kattintás után betölti a fájl tartalmát, és elindítja az automatikus frissítést biztosító időzítőt.  

5. **reloadTimer_Tick(object sender, EventArgs e)**  
   - 6 másodpercenként újra betölti a fájl tartalmát.  

6. **detailsPanel_Paint(object sender, PaintEventArgs e)**  
   - Vizualizálja az időzítő állapotát egy barna téglalap formájában.  

