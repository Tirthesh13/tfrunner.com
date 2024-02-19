using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
//Auth
using Unity.Services.Authentication;
using Unity.Services.Core;
using System;

public class UnityAuthManager : MonoBehaviour
{
    private async void Start()
    {
        try
        {
            await UnityServices.InitializeAsync();
            Debug.Log(UnityServices.State);

            await SignInAnonymouslyAsync();
        }
        catch (Exception exception)
        {

            Debug.Log(exception);
        }
    }
    async Task SignInAnonymouslyAsync()
    {
        try
        {
            if (!AuthenticationService.Instance.IsSignedIn)
            {

                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                if (this == null) return;
            }
            // Debug.Log("Sign in anonymously succeeded!");

            // Shows how to get the playerID
            // Debug.Log($"PlayerID: {AuthenticationService.Instance.PlayerId}");

        }
        catch (AuthenticationException ex)
        {
            // Compare error code to AuthenticationErrorCodes
            // Notify the player with the proper error message
            Debug.LogException(ex);
        }
        catch (RequestFailedException ex)
        {
            // Compare error code to CommonErrorCodes
            // Notify the player with the proper error message
            Debug.LogException(ex);
        }
    }
}
