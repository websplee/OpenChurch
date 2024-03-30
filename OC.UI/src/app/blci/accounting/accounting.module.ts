import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AccountingRoutingModule } from './accounting-routing.module';
import { AccountingComponent } from './accounting.component';
import { ExpensesListComponent } from './expenses-list/expenses-list.component';
import { ExpensesDetailsComponent } from './expenses-details/expenses-details.component';
import { ExpenseTypesDetailsComponent } from './expense-types-details/expense-types-details.component';
import { ExpenseTypesListComponent } from './expense-types-list/expense-types-list.component';
import { IncomeTypesListComponent } from './income-types-list/income-types-list.component';
import { IncomeTypesDetailsComponent } from './income-types-details/income-types-details.component';
import { IncomesListComponent } from './incomes-list/incomes-list.component';
import { IncomeDetailsComponent } from './income-details/income-details.component';
import { SharedModule } from '../../shared/shared.module';


@NgModule({
  declarations: [
    AccountingComponent,
    ExpensesListComponent,
    ExpensesDetailsComponent,
    ExpenseTypesDetailsComponent,
    ExpenseTypesListComponent,
    IncomeTypesListComponent,
    IncomeTypesDetailsComponent,
    IncomesListComponent,
    IncomeDetailsComponent
  ],
  imports: [
    CommonModule,
      AccountingRoutingModule,
    SharedModule,
  ]
})
export class AccountingModule { }
