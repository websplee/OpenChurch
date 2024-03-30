import { NgModule, Optional, SkipSelf } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TableModule } from 'primeng/table';
import { FileUploadModule } from 'primeng/fileupload';
import { FormsModule } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { ToastModule } from 'primeng/toast';
import { ToolbarModule } from 'primeng/toolbar';
import { RippleModule } from 'primeng/ripple';
import { InputTextModule } from 'primeng/inputtext';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { DropdownModule } from 'primeng/dropdown';
import { RadioButtonModule } from 'primeng/radiobutton';
import { InputNumberModule } from 'primeng/inputnumber';
import { DialogModule } from 'primeng/dialog';
import { throwIfAlreadyLoaded } from '../core/module-import-guard';
import { OrderListModule } from 'primeng/orderlist';
import { ListboxModule } from 'primeng/listbox';
import { DynamicDialogModule } from 'primeng/dynamicdialog';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ToggleButtonModule } from 'primeng/togglebutton';
import { DividerModule } from 'primeng/divider';
import { CalendarModule } from 'primeng/calendar';
import { TabMenuModule } from 'primeng/tabmenu';



@NgModule({
  declarations: [],
  imports: [
      CommonModule,
      TableModule,
      FileUploadModule,
      FormsModule,
      ButtonModule,
      RippleModule,
      ToastModule,
      ToolbarModule,
      InputTextModule,
      InputTextareaModule,
      DropdownModule,
      RadioButtonModule,
      InputNumberModule,
      DialogModule,
      ConfirmDialogModule,
      ToggleButtonModule,
      DividerModule,
      CalendarModule,
      TabMenuModule,
    ],
    exports: [
        DynamicDialogModule,
        ListboxModule,
        TableModule,
        OrderListModule,
        FileUploadModule,
        FormsModule,
        ButtonModule,
        RippleModule,
        ToastModule,
        ToolbarModule,
        InputTextModule,
        InputTextareaModule,
        DropdownModule,
        RadioButtonModule,
        InputNumberModule,
        DialogModule,
        ConfirmDialogModule,
        ToggleButtonModule,
        DividerModule,
        CalendarModule,
        TabMenuModule,
      ]
})
export class SharedModule {
    constructor(@Optional() @SkipSelf() parentModule: SharedModule) {
        throwIfAlreadyLoaded(parentModule, 'SharedModule');
    }
}
