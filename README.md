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
