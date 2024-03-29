﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartRover.Batch.App.Model
{
    public class Response
    {
        public DateTime created_date_time { get; set; }
        public DateTime updated_date_time { get; set; }
        public string record_no { get; set; }
        public object version { get; set; }
        public object format { get; set; }
        public string cust_ref { get; set; }
        public string cust_po_no { get; set; }
        public string po_number { get; set; }
        public object carrier { get; set; }
        public string ship_code { get; set; }
        public object ship_code_description { get; set; }
        public object working_ship_code { get; set; }
        public string cust_company { get; set; }
        public object cust_title { get; set; }
        public string cust_first_name { get; set; }
        public string cust_last_name { get; set; }
        public string cust_address_1 { get; set; }
        public string cust_address_2 { get; set; }
        public object cust_address_3 { get; set; }
        public string cust_city { get; set; }
        public string cust_state { get; set; }
        public string cust_zip { get; set; }
        public string cust_country { get; set; }
        public string cust_phone { get; set; }
        public string cust_e_mail { get; set; }
        public string ship_company { get; set; }
        public object ship_title { get; set; }
        public string ship_first_name { get; set; }
        public string ship_last_name { get; set; }
        public string ship_address_1 { get; set; }
        public string ship_address_2 { get; set; }
        public object ship_address_3 { get; set; }
        public string ship_city { get; set; }
        public string ship_state { get; set; }
        public string ship_zip { get; set; }
        public string ship_country { get; set; }
        public string ship_phone { get; set; }
        public string ship_e_mail { get; set; }
        public object ship_address_type { get; set; }
        public object special_services { get; set; }
        public string customer_id { get; set; }
        public string order_date { get; set; }
        public string sub_total { get; set; }
        public string order_discount { get; set; }
        public string sales_tax { get; set; }
        public string shipping_handling { get; set; }
        public string grand_total { get; set; }
        public string balance { get; set; }
        public string currency_code { get; set; }
        public object credit_card_no { get; set; }
        public object expiration_date { get; set; }
        public string pay_type { get; set; }
        public object tax_exempt_sw { get; set; }
        public object installment_program { get; set; }
        public object media_week { get; set; }
        public string order_source { get; set; }
        public object promo_code { get; set; }
        public object ani_phone { get; set; }
        public object vendor_phone { get; set; }
        public object check_account_no { get; set; }
        public object check_type { get; set; }
        public object check_no { get; set; }
        public object check_bank_id { get; set; }
        public object check_cust_bank { get; set; }
        public object check_cust_id_num { get; set; }
        public object check_cust_id_state { get; set; }
        public object check_cust_id_mm { get; set; }
        public object check_cust_id_dd { get; set; }
        public object check_cust_id_yy { get; set; }
        public object check_cust_id_type { get; set; }
        public object location { get; set; }
        public string shipping_instructions { get; set; }
        public object ship_account_no { get; set; }
        public object ship_account_zip { get; set; }
        public object pre_auth_code { get; set; }
        public string pre_auth_amt { get; set; }
        public object pre_auth_id { get; set; }
        public object cvv { get; set; }
        public string custom_field_1 { get; set; }
        public string custom_field_2 { get; set; }
        public string custom_field_3 { get; set; }
        public object custom_field_4 { get; set; }
        public object custom_field_5 { get; set; }
        public object gift_card_sw { get; set; }
        public object token_sw { get; set; }
        public string cass_code_ship { get; set; }
        public object cass_error_ship { get; set; }
        public object cass_code_cust { get; set; }
        public object cass_error_cust { get; set; }
        public object cass_date { get; set; }
        public object ncoa_code_ship { get; set; }
        public object ncoa_code_cust { get; set; }
        public object ncoa_date { get; set; }
        public object error_code { get; set; }
        public object error_msg { get; set; }
        public object ifraud_error_code { get; set; }
        public object xfraud_error_code { get; set; }
        public object credit_error_code { get; set; }
        public object resubmit_date { get; set; }
        public object black_list { get; set; }
        public object credit_score { get; set; }
        public object fraud_score { get; set; }
        public object load_override_sw { get; set; }
        public object fail_action { get; set; }
        public object action_dt { get; set; }
        public object filename { get; set; }
        public object call_queue { get; set; }
        public object clerk_disposition { get; set; }
        public object clerk_disp_dt { get; set; }
        public object rep_disposition { get; set; }
        public object rep_disp_dt { get; set; }
        public object duplicate_sw { get; set; }
        public string weight { get; set; }
        public object org_file_no { get; set; }
        public object gift_message { get; set; }
        public object gift_wrap { get; set; }
        public object delete_date { get; set; }
        public string routing_sw { get; set; }
        public object sent_to_region { get; set; }
        public object accepted_by_region { get; set; }
        public object regional_center { get; set; }
        public object regional_order_no { get; set; }
        public object regional_ship_date { get; set; }
        public string regional_retry_sw { get; set; }
        public object regional_error { get; set; }
        public string regional_attempts { get; set; }
        public object first_attempt { get; set; }
        public object cancel_date { get; set; }
        public object cc_last_four { get; set; }
        public string expected_delivery_date { get; set; }
        public string requested_ship_date { get; set; }
        public DateTime? delivered_to_wms_date { get; set; }
        public object error_reason { get; set; }
        public DateTime mark_in_progress_date { get; set; }
        public object extra_system_date_sent { get; set; }
        public string sending_canceled { get; set; }
        public string shipping_pickup_canceled { get; set; }
        public string on_hold { get; set; }
        public string num_failed_sends { get; set; }
        public string inventory_warehouse_pk { get; set; }
        public object latest_ship_date { get; set; }
        public object log_documents_in { get; set; }
        public object log_documents_out { get; set; }
        public object mark_in_progress_log { get; set; }
        public string orig_ship_code { get; set; }
        public object orig_carrier { get; set; }
        public string order_status { get; set; }
        public List<Item> items { get; set; }
        public List<Shipment> shipments { get; set; }
    }
    

}
