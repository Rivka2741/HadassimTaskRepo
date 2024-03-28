import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UsersComponent } from './components/users/users.component';
import { SickWithCoronaComponent } from './components/sick-with-corona/sick-with-corona.component';
import { VaccinationDetailComponent } from './components/vaccination-detail/vaccination-detail.component';
import { VaccineManufacturerComponent } from './components/vaccine-manufacturer/vaccine-manufacturer.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatTableModule } from '@angular/material/table';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatDialogModule } from '@angular/material/dialog';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { MyCoronaDateComponent } from './components/my-corona-date/my-corona-date.component';
import { UserVaccinationHistoryComponent } from './components/user-vaccination-history/user-vaccination-history.component';
import { PatientActivityGraphComponent } from './components/patient-activity-graph/patient-activity-graph.component';

@NgModule({
  declarations: [
    AppComponent,
    UsersComponent,
    SickWithCoronaComponent,
    VaccinationDetailComponent,
    VaccineManufacturerComponent,
    MyCoronaDateComponent,
    UserVaccinationHistoryComponent,
    PatientActivityGraphComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    MatTableModule,
    MatFormFieldModule,
    MatPaginatorModule,
    MatSortModule,
    MatDialogModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
