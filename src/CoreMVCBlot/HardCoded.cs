using fastJSON;
using MBrace.FsPickler.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NETStandaloneBlot.Other
{
    public class HardCodedVuln
    {
        //# ruleid: detected-amazon-mws-auth-token
        string amazon_token = "amzn.mws.00a19111-8311-5311-5391-5e211cbfcd5c";

/       //# ruleid: detected-artifactory-password
        string detected-artifactory = "AP6xxxxxxxxxx";

        // # ruleid: detected-artifactory-token
        string artif-key= "AKCxxxxxxxxxx";

        //# ruleid: detected-aws-access-key-id-value
        string detected-aws-access = "AKIAIOSFODNN7EXAMPLE";

        //# ruleid: detected-aws-account-id
        string aws_account_id = "123456789012";

        //# ruleid: detected-aws-appsync-graphql-key
        string detected-aws-graphql-key = "da2-vphx3xhhzbhutep25pfcgdzlte";

        //# ruleid: detected-aws-secret-access-key
        string aws_secret_access_key = "wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY";

        //# ruleid: detected-aws-session-token
        string  export AWS_SESSION_TOKEN = "FQoGZXIvYXdzENv//////////wEaDEeLj11xTbnBk6azRCKsAacCiJK85DSXExJ81GtHrkEyev8eedQcFY4EoM00PsD1FAEMOfzQclVEFsoh9Y4ZHUjgGmCPRUnYCLNc2NnHkadvmI+MT7jRRa1Mo2HA/HYStOOwEyfXFYG91MNj9rVXXXXXXXXA6+7FF6jcxj3cr1U9CDB9hjW+jGq4UgjxXXXXXXXCoIidDjl4Z911zIzP/Q+FYA1R2CUz5Y32EUaMzR+bQvmheUolLOq3wU=aws ec2 describe-instances --region us-west-1";

        //# ruleid: detected-codeclimate
        string CODECLIMATE_API_TOKEN = "746b31b417ecc5cff872bac5746b31b417ecc5cff872bac51234567890abcdef";

        //# ruleid: detected-etc-shadow
        string root = "root::17431:0:99999:7:::";
        string daemon = "daemon:*:17431:0:99999:7:::";
        string bin = "bin:*:17431:0:99999:7:::";
        string sys = "sys:*:17431:0:99999:7:::";
        string sync = "sync:*:17431:0:99999:7:::";
        string games = "games:*:17431:0:99999:7:::";
        string man = "man:*:17431:0:99999:7:::";
        string lp = "lp:*:17431:0:99999:7:::";
        string mail = "mail:*:17431:0:99999:7:::";
        string news = "news:*:17431:0:99999:7:::";
        string uucp = "uucp:*:17431:0:99999:7:::";
        string proxy =" proxy:*:17431:0:99999:7:::";
        string www-data = "www-data:*:17431:0:99999:7:::";
        string backup = "backup:*:17431:0:99999:7:::";
        string list = "list:*:17431:0:99999:7:::";
        string irc = "irc:*:17431:0:99999:7:::";
        string gnats = "gnats:*:17431:0:99999:7:::";
        string nobody = "nobody:*:17431:0:99999:7:::";
        string sshd = "sshd:*:17431:0:99999:7:::";
        string ubuntu = "ubuntu:$6$LnUhhUi45srUKt9i$4Hp6VRTOB2mxvsYH8mwsCfBryg6hCbm4JJjV26KplN8ewZ7EUVqQDkLKDW.O8XRHx.B76JkwXtyD3wnAXEuZN1:0:99999:7:::";


        //# ruleid: detected-facebook-access-token
        string User UID groub = "https://graph.facebook.com/v2.8/218718188140085/members?access_token=EAACEdEose0cBAMF99BFdceBHS5UcaEPIDbhKT1nbE0DaulfIS8ZCJTHrkD6IxkfKZCObCHzUsHcdhBISYuv7L4oiylZCmNztRy6s9KBgmZBYbJxZBBk1Csjl8PXFnZA3rt5WwZB7dZCB9M04a6FI7XwCFXfNV4ZB76y6SjltVc4AP4gZDZD&pretty=0&fields=id&limit=1000&after=MzQxNDM1MTE2MjQ0Njk4";

        //# ruleid: detected-facebook-oauth
        string facebook-oauth ="https://graph.facebook.com/oauth/access_token?client_id=571605572000175&client_secret=c3cc928991d69e784f69a907000cc909&grant_type=client_credentials";

        //# ruleid: detected-generic-api-key
        string api_key = "1234567890123456789012345678901234567890";

        //# ruleid: detected-generic-secret
        string secret = "1234567890123456789012345678901234567890";

        //# ruleid: detected-github-token
        string GITHUB_TOKEN = "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";

        //# ruleid: detected-google-cloud-api-key
        string detected-google-cloud-api-key = "AIzaSyCqhkgrLTLSOFyLyoS5gfN47TJ0HnHA_XA";

        //# ruleid: detected-google-oauth-url
        string google-oauth-url = "300061924372-UR9fg7OO3Ajs6nvr5s4kQNugr4j8tsf2.apps.googleusercontent.com";

        //# ruleid: detected-heroku-api-key
        string HEROKU_API_KEY = "A6264401-E60A-48A9-941F-6446E78EC164";

        //# ruleid: detected-jwt-token
        string jwt-token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJuYW1lIjoiSm9lIiwKInN0YXR1cyI6ImVtcGxveWVlIgp9";

        //# ruleid: detected-mailchimp-api-key
        string mailchimp-api-key = "ac954d9304919994498d92eb0c1669b0-us8";

        //# ruleid: detected-mailgun-api-key
        string mailgun-api-key = "key-e98f02fb71f9ee886e96588012341ca0";

        //# ruleid: detected-npm-token
        string npm-token = "_authToken=xxxxxxxxxxxxxxxxxxxx";

        //# ruleid: detected-outlook-team
        string outlook-team = "https://outlook.office.com/webhook/9e10b0f2-b994-4bff-b106-473c37cdc555@";

         //# ruleid: detected-paypal-braintree-access-token
        string paypal-braintree-token = "access_token$production$aaa722wk737379q3$afefae5za65de111123a72251111e065";


        /*
         * # ruleid: detected-pgp-private-key-block
            -----BEGIN PGP PRIVATE KEY BLOCK-----
            Version: Keybase OpenPGP v1.0.0
            Comment: https://keybase.io/crypto

            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
            X2Y/76F6KQg=
            =6Acw
            -----END PGP PRIVATE KEY BLOCK-----
                     */
        /*# ruleid: detected-private-key
            -----BEGIN RSA PRIVATE KEY-----
            MIIEogIBAAKCAQEAjosMtDUqbE1/8zxZac1t8fkh2SxGuMXHk9yxniyM2m76donW
         */


         //# ruleid: detected-sauce-token
         string SAUCE_ACCESS_KEY = "034e1d2a-681a-4a52-bfa3-256b72c356c0";

        //# ruleid: detected-sendgrid-api-key
        string sendgrid-api-key = "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";

        //# ruleid: detected-slack-token
        string SLACK_TOKEN = "xoxb-244636495000-244564491300-Wwpw98abcdabcdefabcdabcz";

        //# ruleid: detected-slack-webhook
        string slack-webhook = "https://hooks.slack.com/services/T12345678/B12345678/abcd1234efgh5678ijkl90zy";

        //# ruleid: detected-snyk-api-key
        string snyktoken = "12e45678-12e4-12e4-12e4-12e456789012";

        //# ruleid: detected-softlayer-api-key
        string softlayer = "abcd1234abcd1234abcd1234abcd1234abcd1234abcd1234abcd1234abcd1234";

        //# ruleid: detected-sonarqube-docs-api-key
        string SONARQUBE = "5eeee8e4deeee2dbfeeeedbeeeec37b7eeeea7b9";

        //# ruleid: detected-square-access-token
        string square-access-token = "sq0atp-KoblahBLAHBLAHbEHA6yuw";

        //# ruleid: detected-square-oauth-secret
        string square-oauth-secret = "square_oauth = sq0csp-ABCDEFGHIJK_LMNOPQRSTUVWXYZ-0123456789\abcd";

        //# ruleid: detected-stripe-api-key
        string stripe-api-key = "sk_live_xf2fh0Hu3LqXlqqUg2DEWhEz";

        //# ruleid: detected-stripe-restricted-api-key
        string stripe-api-key = "rk_live_xf2fh0Hu3LqXlqqUg2DEWhEz";

        // ruleid: detected-telegram-bot-api-key
        string telegram-bot-api-key = "12345678:AA101703Wd8JLT6GCtKzxatRHQREQUk_CpK";

         //# ruleid: detected-twilio-api-key
        string twilio-api-key = "SK575796bb721246b5fe003bcc32ebde77";

         //# ruleid: detected-twitter-access-token
        string TWITTER_ACCESS_TOKEN = "14541334523-l2zGWkszwtccc5wWtyJFkCN3wtc5wWtyJFkCN3Yz";

        //# ruleid: detected-username-and-password-in-uri
        string username-password-uri = "https://username:password@example.com";
    }
}
