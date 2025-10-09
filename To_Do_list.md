# To-Do Design
##
* [ ] Add search bar to the ViewAllSuperheroes screen
* [ ] New UserContorl for editing of heroes

## Overall

* [ ] Add icon to the app — Waldo
* [ ] Add hover animation to the nav bar buttons — Waldo
* [ ] Add rounded corners for pnl??? — Waldo
* [ ] Consider gradients for btn/pnl??? — Waldo

---

# Functionality To-Do - Timeline to have finished by 18/10/2025

## **Waldo – File Handling & Data Model**

**Tasks**

* Design the `Superhero` class with fields:
  **ID**, **Name**, **Age**, **Superpower**, **ExamScore**, **Rank**, **ThreatLevel**.
* Implement helper methods to:

  * Calculate **Rank** and **ThreatLevel** from `ExamScore`.
  * Read and write hero data to `superheroes.txt`.
  * Handle file creation, missing file errors, and general file I/O validation.
* Validate all inputs (e.g., score between 0–100, no empty fields).

**Deliverables**

* `Superhero.cs`
* `Superheroes_FileHandler.cs` utility class
* Full input validation and exception handling

---

## **Alex – AddHero Screen Logic**

**Tasks**

* Link UI elements to backend logic.
* Implement **Add New Hero** feature:

  * Capture and validate form input.
  * Auto-calculate Rank and Threat Level using Waldo’s methods.
  * Append the new hero record to `superheroes.txt`.
* Display success and error messages.

**Deliverables**

* Fully functional **AddHero** form with file handling methods implemented from Waldo
* User validation feedback messages

---

## **Christian – ViewAllHeroes Screen Logic**

**Tasks**

* Load heroes from `superheroes.txt` into a **DataGridView**.
* Implement:
  * **Search bar** — Functionality for the search bar
  * **Edit** — load hero data into form fields for updates and save changes.
  * **Delete** — remove hero from file with confirmation.
* Ensure the DataGridView refreshes correctly after add/update/delete actions.
* Coordinate with Waldo to maintain file read/write consistency.

**Deliverables**

* Functional **ViewAllHeroes** form with file integration
* Completed Edit and Delete features
* Reliable data refresh functionality

---

## **Willem – Summary Screen**

**Tasks**

* Implement **Summary Report** feature:

  * Calculate total heroes, average age, average exam score, and heroes per rank - Then update the SummaryScreen page in the Windows from accordingly
  * Display results in the summary form.
  * Save summary data to `summary.txt`.

**Deliverables**

* `Summary_FileHandler.cs` (handles creation of `summary.txt` and related logic)
* Functional Summary form
* Correctly formatted `summary.txt` output

---

# Example File Structures

## `superheroes.txt`

Pipe (`|`) delimited file example:

```
HeroID | Name | Age | Superpower | ExamScore | Rank | ThreatLevel
H001|Astra Blaze|22|Fire Manipulation|95|S|Finals Week
H002|Shadow Lynx|19|Stealth and Agility|78|A|Midterm Madness
H003|Volt Surge|24|Electrokinesis|56|B|Group Project Gone Wrong
H004|Crystal Veil|20|Energy Shielding|38|C|Pop Quiz
H005|Iron Gale|27|Metal Control|82|S|Finals Week
```

---

## `summary.txt`

```
=== HERO SUMMARY REPORT ===

Total Number of Heroes: 5
Average Age: 22.4
Average Exam Score: 69.8

Number of Heroes per Rank:
S-Rank: 2
A-Rank: 1
B-Rank: 1
C-Rank: 1

Generated On: 10/9/2025 5:15:37 PM
================================
```

**Note:**
Use `DateTime.Now` to generate the “Generated On” timestamp. Append to the existing file to maintain a log.

---

# Repo To-Do

* [ ] Update `README.md`. - Waldo
* [ ] Create GitHub Releases for the app (ask **Jaden** how this is done) - Waldo
