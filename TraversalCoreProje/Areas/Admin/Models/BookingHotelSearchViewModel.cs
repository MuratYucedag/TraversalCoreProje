using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Admin.Models
{
    public class BookingHotelSearchViewModel
    {
            public int primary_count { get; set; }
            public int count { get; set; }
            public Room_Distribution[] room_distribution { get; set; }
            public Map_Bounding_Box map_bounding_box { get; set; }
            public int total_count_with_filters { get; set; }
            public int unfiltered_count { get; set; }
            public int extended_count { get; set; }
            public int unfiltered_primary_count { get; set; }
            public int search_radius { get; set; }
            public Sort[] sort { get; set; }
            public Result[] result { get; set; }   

        public class Map_Bounding_Box
        {
            public float sw_lat { get; set; }
            public float ne_lat { get; set; }
            public float ne_long { get; set; }
            public float sw_long { get; set; }
        }

        public class Room_Distribution
        {
            public int[] children { get; set; }
            public string adults { get; set; }
        }

        public class Sort
        {
            public string name { get; set; }
            public string id { get; set; }
        }

        public class Result
        {
            public int is_free_cancellable { get; set; }
            public int hotel_id { get; set; }
            public int native_ads_cpc { get; set; }
            public int is_smart_deal { get; set; }
            public int extended { get; set; }
            public int hotel_include_breakfast { get; set; }
            public string timezone { get; set; }
            public Checkin checkin { get; set; }
            public int class_is_estimated { get; set; }
            public string native_ad_id { get; set; }
            public float mobile_discount_percentage { get; set; }
            public object updated_checkin { get; set; }
            public string default_wishlist_name { get; set; }
            public int preferred { get; set; }
            public float latitude { get; set; }
            public int _class { get; set; }
            public int ufi { get; set; }
            public string id { get; set; }
            public int accommodation_type { get; set; }
            public Bwallet bwallet { get; set; }
            public int is_genius_deal { get; set; }
            public string countrycode { get; set; }
            public string distance_to_cc_formatted { get; set; }
            public int cant_book { get; set; }
            public string currencycode { get; set; }
            public float min_total_price { get; set; }
            public float longitude { get; set; }
            public string currency_code { get; set; }
            public int is_no_prepayment_block { get; set; }
            public string unit_configuration_label { get; set; }
            public Price_Breakdown price_breakdown { get; set; }
            public string[] block_ids { get; set; }
            public int soldout { get; set; }
            public Badge[] badges { get; set; }
            public int main_photo_id { get; set; }
            public string city_in_trans { get; set; }
            public int hotel_has_vb_boost { get; set; }
            public Distance[] distances { get; set; }
            public int genius_discount_percentage { get; set; }
            public string hotel_name { get; set; }
            public string accommodation_type_name { get; set; }
            public int price_is_final { get; set; }
            public string type { get; set; }
            public Matching_Units_Configuration matching_units_configuration { get; set; }
            public int children_not_allowed { get; set; }
            public string hotel_name_trans { get; set; }
            public string main_photo_url { get; set; }
            public string city { get; set; }
            public float review_score { get; set; }
            public object updated_checkout { get; set; }
            public object is_geo_rate { get; set; }
            public string default_language { get; set; }
            public Checkout checkout { get; set; }
            public object selected_review_topic { get; set; }
            public string native_ads_tracking { get; set; }
            public int review_nr { get; set; }
            public string review_score_word { get; set; }
            public int is_mobile_deal { get; set; }
            public int preferred_plus { get; set; }
            public Composite_Price_Breakdown composite_price_breakdown { get; set; }
            public string max_photo_url { get; set; }
            public string max_1440_photo_url { get; set; }
            public Booking_Home booking_home { get; set; }
            public int has_swimming_pool { get; set; }
        }

        public class Checkin
        {
            public string from { get; set; }
            public string until { get; set; }
        }

        public class Bwallet
        {
            public int hotel_eligibility { get; set; }
        }

        public class Price_Breakdown
        {
            public float all_inclusive_price { get; set; }
            public int has_tax_exceptions { get; set; }
            public int has_fine_print_charges { get; set; }
            public string currency { get; set; }
            public string sum_excluded_raw { get; set; }
            public float gross_price { get; set; }
            public int has_incalculable_charges { get; set; }
        }

        public class Matching_Units_Configuration
        {
            public Matching_Units_Common_Config matching_units_common_config { get; set; }
        }

        public class Matching_Units_Common_Config
        {
            public int unit_type_id { get; set; }
            public string localized_area { get; set; }
        }

        public class Checkout
        {
            public string from { get; set; }
            public string until { get; set; }
        }

        public class Composite_Price_Breakdown
        {
            public Benefit[] benefits { get; set; }
            public int has_long_stays_monthly_rate_price { get; set; }
            public Included_Taxes_And_Charges_Amount included_taxes_and_charges_amount { get; set; }
            public All_Inclusive_Amount all_inclusive_amount { get; set; }
            public Gross_Amount gross_amount { get; set; }
            public int has_long_stays_weekly_rate_price { get; set; }
            public Item[] items { get; set; }
            public Gross_Amount_Hotel_Currency gross_amount_hotel_currency { get; set; }
            public Excluded_Amount excluded_amount { get; set; }
            public Gross_Amount_Per_Night gross_amount_per_night { get; set; }
            public Net_Amount net_amount { get; set; }
            public Product_Price_Breakdowns[] product_price_breakdowns { get; set; }
            public Strikethrough_Amount_Per_Night strikethrough_amount_per_night { get; set; }
            public Discounted_Amount discounted_amount { get; set; }
            public Strikethrough_Amount strikethrough_amount { get; set; }
        }

        public class Included_Taxes_And_Charges_Amount
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class All_Inclusive_Amount
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Gross_Amount
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Gross_Amount_Hotel_Currency
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Excluded_Amount
        {
            public int value { get; set; }
            public string currency { get; set; }
        }

        public class Gross_Amount_Per_Night
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Net_Amount
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Strikethrough_Amount_Per_Night
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Discounted_Amount
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Strikethrough_Amount
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Benefit
        {
            public object icon { get; set; }
            public string details { get; set; }
            public string name { get; set; }
            public string identifier { get; set; }
            public string kind { get; set; }
            public string badge_variant { get; set; }
        }

        public class Item
        {
            public Item_Amount item_amount { get; set; }
            public string name { get; set; }
            public string inclusion_type { get; set; }
            public string kind { get; set; }
            public Base _base { get; set; }
            public string details { get; set; }
            public string identifier { get; set; }
        }

        public class Item_Amount
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Base
        {
            public float base_amount { get; set; }
            public string kind { get; set; }
            public int percentage { get; set; }
        }

        public class Product_Price_Breakdowns
        {
            public Gross_Amount_Hotel_Currency1 gross_amount_hotel_currency { get; set; }
            public Net_Amount1 net_amount { get; set; }
            public Excluded_Amount1 excluded_amount { get; set; }
            public Gross_Amount_Per_Night1 gross_amount_per_night { get; set; }
            public Gross_Amount1 gross_amount { get; set; }
            public Item1[] items { get; set; }
            public int has_long_stays_weekly_rate_price { get; set; }
            public Benefit1[] benefits { get; set; }
            public int has_long_stays_monthly_rate_price { get; set; }
            public Included_Taxes_And_Charges_Amount1 included_taxes_and_charges_amount { get; set; }
            public All_Inclusive_Amount1 all_inclusive_amount { get; set; }
            public Strikethrough_Amount_Per_Night1 strikethrough_amount_per_night { get; set; }
            public Discounted_Amount1 discounted_amount { get; set; }
            public Strikethrough_Amount1 strikethrough_amount { get; set; }
        }

        public class Gross_Amount_Hotel_Currency1
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Net_Amount1
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Excluded_Amount1
        {
            public int value { get; set; }
            public string currency { get; set; }
        }

        public class Gross_Amount_Per_Night1
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Gross_Amount1
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Included_Taxes_And_Charges_Amount1
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class All_Inclusive_Amount1
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Strikethrough_Amount_Per_Night1
        {
            public string currency { get; set; }
            public float value { get; set; }
        }

        public class Discounted_Amount1
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Strikethrough_Amount1
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Item1
        {
            public Base1 _base { get; set; }
            public string details { get; set; }
            public string name { get; set; }
            public Item_Amount1 item_amount { get; set; }
            public string inclusion_type { get; set; }
            public string kind { get; set; }
            public string identifier { get; set; }
        }

        public class Base1
        {
            public float base_amount { get; set; }
            public string kind { get; set; }
            public int percentage { get; set; }
        }

        public class Item_Amount1
        {
            public float value { get; set; }
            public string currency { get; set; }
        }

        public class Benefit1
        {
            public object icon { get; set; }
            public string details { get; set; }
            public string name { get; set; }
            public string identifier { get; set; }
            public string kind { get; set; }
            public string badge_variant { get; set; }
        }

        public class Booking_Home
        {
            public string group { get; set; }
            public int segment { get; set; }
            public int quality_class { get; set; }
            public string is_single_unit_property { get; set; }
            public int is_booking_home { get; set; }
        }

        public class Badge
        {
            public string id { get; set; }
            public string text { get; set; }
            public string badge_variant { get; set; }
        }

        public class Distance
        {
            public string text { get; set; }
            public string icon_name { get; set; }
            public object icon_set { get; set; }
        }
    }
}
